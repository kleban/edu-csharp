using LocalitiesApp.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocalitiesApp
{
    public class DataManager
    {
        public Country[] GetInitialData()
        {
            Village v1 = new Village { Name = "Progres" };
            Village v2 = new Village { Name = "Vesele" };
            City c1 = new City { Name = "Ostroh", IsBig = false };
            City c2 = new City { Name = "Zdolbuniv", IsBig = false };
            Region r = new Region
            {
                Name = "Rivne region",
                Localities = new Locality[4] { v1, c1, v2, c2 }
            };

            Country country = new Country
            {
                Name = "Ukraine",
                CountryCode = "UA",
                Population = 30000000,
                Regions = new[] { r }
            };

            return new Country[] { country };
        }

        public Country[] AddCountry(Country[] data, Country country)
        {
            Array.Resize(ref data, data.Length + 1);
            data[data.Length - 1] = country;
            return data;
        }
    }
}
