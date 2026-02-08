using ForbesRank.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForbesRank.Repos
{
    public interface ICountryRepository
    {
        void Create(Country country);
        Country Get(int id);
        IEnumerable<Country> GetAll();
        void Update(Country country);
        void Delete(int id);
    }
}
