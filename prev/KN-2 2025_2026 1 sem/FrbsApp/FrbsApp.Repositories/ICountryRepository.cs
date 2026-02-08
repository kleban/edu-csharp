using FrbsApp.Core.Models;

namespace FrbsApp.Repositories
{
    public interface ICountryRepository
    {
        IEnumerable<Country> GetAll();
        Country? GetById(int id);
        void Add(Country country);
        void Update(Country country);
        void Delete(int id);
    }
}
