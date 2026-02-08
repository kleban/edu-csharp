using System;
using System.Collections.Generic;
using System.Text;

namespace FrbsApp.Repositories
{
    public interface IRepository<T> where T : class
    {
        // Отримати всі записи
        IEnumerable<T> GetAll();

        // Отримати один запис за ідентифікатором
        T GetById(int id);

        // Додати новий запис
        void Add(T entity);

        // Оновити існуючий запис
        void Update(T entity);

        // Видалити запис
        void Delete(int id);

        // Зберегти зміни
        void Save();
    }

}
