using FrbsApp.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace FrbsApp.Repositories
{
    public class CountryRepository2 : Repository<Country>
    {
        public CountryRepository2(FrbsApp.Core.Context.FrbsContext context) : base(context)
        {
            
        }

        public IEnumerable<Country> GetCountriesByContinent(string continent)
        {
            // Example of a specialized method for CountryRepository2
            throw new NotImplementedException();
        }
    }
}
