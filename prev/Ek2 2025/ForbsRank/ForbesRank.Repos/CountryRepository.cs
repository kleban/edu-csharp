using ForbesRank.Domain.Context;
using ForbesRank.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForbesRank.Repos
{
    public class CountryRepository : ICountryRepository
    {
        private readonly ForbesContext context;
        public CountryRepository(ForbesContext context)
        {
            this.context = context ?? throw new ArgumentNullException(nameof(context));
        }
        public void Create(Country country)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Country Get(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Country> GetAll()
        {
            return context.Countries.ToList();
        }

        public void Update(Country country)
        {
            throw new NotImplementedException();
        }
    }
}
