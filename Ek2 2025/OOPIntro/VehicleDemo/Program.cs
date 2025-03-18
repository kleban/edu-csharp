/*

1. Створіть базовий клас `Vehicle` з такими
властивостями, як `Brand` (марка), `Speed` 
(швидкість) і метод `Move()`, 
який виводить повідомлення про рух.
2. Реалізуйте похідні класи `Car` (автомобіль) і 
`Bicycle` (велосипед), які перевизначають метод
`Move()`, щоб враховувати особливості руху.
Велосипед рухається зі швидкістю 5-15 км/год, а автомобіль 15-100км/год (генерується випадковим чином.
3. Додайте унікальні властивості для кожного з підкласів, 
наприклад, `FuelType` (`enum`) для автомобіля та `HasBell` (bool) для велосипеда.

 */

using VehicleDemo.Models;

Car car = new Car("Tesla", 88, FuelType.Electric);
Bicycle bicycle = new Bicycle("Stels", 12, true);

Vehicle[] vehicles = new Vehicle[] { car, bicycle };

foreach (var vehicle in vehicles)
{
    vehicle.Move();
}
