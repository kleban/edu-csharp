using ForbesRank.Domain.Context;
using ForbesRank.Domain.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForbesRank.Repositories
{
    public class CountryRepository : ICountryRepository
    {
        public int Add(Country country)
        {
            using (var ctx = new ForbesContext())
            {
                var obj = ctx.Countries.Add(country);
                ctx.SaveChanges();
                return obj.Entity.Id;
            }
        }

        public void Delete(int id)
        {
            using (var ctx = new ForbesContext())
            {
                ctx.Countries.Remove(ctx.Countries.First(x => id == x.Id));
                ctx.SaveChanges();
            }
        }

        public Country Get(int id)
        {
            using (var ctx = new ForbesContext())
            {
                return ctx.Countries.First(x => id == x.Id);
            }
        }

        public IEnumerable<Country> GetAll()
        {
            using (var ctx = new ForbesContext())
            {
                return ctx.Countries.OrderBy(x => x.Title).ToList();
            }
        }

        public void Update(Country country)
        {
            using (var ctx = new ForbesContext())
            {
                var obj = ctx.Countries.First(x => country.Id == x.Id);
                if (obj.Title != country.Title)
                {
                    obj.Title = country.Title;
                    ctx.SaveChanges();
                }
            }
        }
    }
}


