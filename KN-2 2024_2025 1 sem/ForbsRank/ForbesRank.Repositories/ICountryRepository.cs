using ForbesRank.Domain.Models;

namespace ForbesRank.Repositories
{
    public interface ICountryRepository
    {
        IEnumerable<Country> GetAll();
        Country Get(int id);
        int Add(Country country);
        void Delete(int id);
        void Update(Country country);
    }
}
