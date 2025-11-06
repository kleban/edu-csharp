using FrbsApp.Core.Context;
using FrbsApp.Core.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Text;

namespace FrbsApp.Repositories
{
    public class CountryRepository : ICountryRepository
    {
        public void Add(Country country)
        {
            using (var ctx = new FrbsContext())
            {
                ctx.Countries.Add(country);
                ctx.SaveChanges();
            }
        }

        public void Delete(int id)
        {
            using (var ctx = new FrbsContext())
            {
                if (ctx.Countries.Any(x => x.Id == id))
                {
                    ctx.Countries.Remove(ctx.Countries.First(x => x.Id == id));
                    ctx.SaveChanges();
                }
            }
        }

        public IEnumerable<Country> GetAll()
        {
            using (var ctx = new FrbsContext())
            {
                return ctx.Countries.ToList();
            }
        }

        public Country? GetById(int id)
        {
            using (var ctx = new FrbsContext())
            {
                return ctx.Countries.FirstOrDefault(x => x.Id == id);
            }
        }

        public void Update(Country country)
        {
            using (var ctx = new FrbsContext())
            {
                if (ctx.Countries.Any(x => x.Id == country.Id))
                {
                    var updCountry = ctx.Countries.First(x => x.Id == country.Id);
                    if(updCountry.Name != country.Name)
                        updCountry.Name = country.Name;
                    //ctx.Countries.Update(country);
                    ctx.SaveChanges();
                }
            }
        }
    }
}
