# LAB_API.md — CityExplorer

## Сценарій інтеграції

**Назва:** «Збагачена картка туристичного міста»

**Проблема користувача:** адміністратор веде список туристичних міст у локальній БД.
Для кожного міста він хоче бачити актуальну погоду, координати і країнознавчу довідку —
без ручного оновлення.

**Потік даних:**
1. З локальної SQLite БД береться місто (`City`) — назва, опис, назва країни.
2. Через **Nominatim** отримуються координати (lat/lon).
3. Координати передаються у **Open-Meteo** → прогноз погоди.
4. Назва країни передається у **REST Countries** → валюта, мови, прапор (emoji).
5. Усе збирається в одну `CityDetailsViewModel` і відображається у Razor View.

---

## Використані зовнішні API

| API | Endpoint | Отримані дані | Ключ? | Кешування |
|---|---|---|---|---|
| [Nominatim](https://nominatim.openstreetmap.org/) | `/search?q=...&format=json&limit=1` | lat, lon, display_name | ні | ні |
| [Open-Meteo](https://open-meteo.com/) | `/v1/forecast?latitude=...&longitude=...&current=...` | температура, вітер, weather_code | ні | ні |
| [REST Countries](https://restcountries.com/) | `/v3.1/name/{name}?fields=name,currencies,languages,flag` | валюта, мови, emoji прапор | ні | **24 год** |

---

## Fallback-стратегії

- **Nominatim недоступний** → `vm.Latitude = null`, погода не завантажується,
  у View показується попередження «Координати міста не вдалося визначити».
- **Open-Meteo недоступний** → `WeatherAvailable = false`,
  у View ховається блок погоди, показується попередження.
- **REST Countries недоступний** → `CountryInfoAvailable = false`,
  у View ховається блок країни, показується попередження.
- **Жоден API не впливає на доступність локальних даних з БД.**

---

## Resilience (Polly)

Всі три `HttpClient` зареєстровані з `.AddStandardResilienceHandler()`:

| Шар | Поведінка |
|---|---|
| **Timeout** | 8 сек на запит |
| **Retry** | 3 спроби з exponential backoff при 5xx та таймаутах |
| **Circuit Breaker** | Після 5 невдач — зупиняє запити на ~60 сек |

---

## Кешування

- `REST Countries` → `IMemoryCache`, ключ `country:{name}`, TTL = 24 год.
- **Обґрунтування:** валюта, мови та прапор країни змінюються дуже рідко;
  кешування знижує навантаження на зовнішній сервіс.
- `Open-Meteo` та `Nominatim` — **не кешуються**:
  погода змінюється щогодини, координати потрібні завжди актуальні.

---

## Власний Web API

- Controller: `CitiesApiController` → `/api/cities`
- Swagger UI: `/swagger`

| Метод | Endpoint | Опис |
|---|---|---|
| GET | `/api/cities` | Список усіх міст |
| GET | `/api/cities/{id}` | Місто за ID |
| POST | `/api/cities` | Додати місто |
| PUT | `/api/cities/{id}` | Оновити місто |
| DELETE | `/api/cities/{id}` | Видалити місто |

---

## Безпека API ключів

Цей проєкт використовує лише безкоштовні API без ключів.
Для демонстрації принципу безпечного зберігання:

- `appsettings.Development.json` — у `.gitignore`, порожній
- `appsettings.Development.json.example` — шаблон із заповнювачами

---

## Як запустити

```bash
cd CityExplorer
dotnet restore
dotnet run
```

Потім відкрити:
- http://localhost:5000 — MVC-застосунок
- http://localhost:5000/swagger — Swagger API документація
- http://localhost:5000/Cities — список міст
- http://localhost:5000/Cities/Details/1 — збагачена картка Kyiv
