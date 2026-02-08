using ForbesRank.Domain.Context;
using ForbesRank.Domain.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForbesRank.Repositories
{
    public class PersonRepository : IPersonRepository
    {
        public int Add(Person person)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Person Get(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Person> GetAll()
        {
            using (var ctx = new ForbesContext())
            {
                var data = ctx.Persons
                    .Include(x=> x.Category)
                    .Include(x=> x.Country)
                    .OrderBy(x=> x.FinalWorth)
                    .OrderBy(x=> x.Rank)
                    .ToList();
                return data;
            }
        }

        public void Update(Person person)
        {
            throw new NotImplementedException();
        }
    }
}
