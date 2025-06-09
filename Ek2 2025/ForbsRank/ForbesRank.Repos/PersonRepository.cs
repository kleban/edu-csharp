using ForbesRank.Domain.Context;
using ForbesRank.Domain.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForbesRank.Repos
{
    public class PersonRepository : IPersonRepository
    {
        private readonly ForbesContext context;
        public PersonRepository(ForbesContext context)
        {
            this.context = context ?? throw new ArgumentNullException(nameof(context));
        }
        public void Create(Person person)
        {
            context.Persons.Add(person);
            context.SaveChanges();
            ReRank(); // Re-rank after adding a new person
        }



        public void Delete(int id)
        {
            var obj = context.Persons.Find(id);
            if (obj != null)
            {
                context.Persons.Remove(obj);
                context.SaveChanges();
            }
        }

        public Person Get(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Person> GetAll()
        {
            return context.Persons
                .Include(x => x.Category)
                .Include(c => c.Country).ToList();
        }

        public void Update(Person person)
        {
            throw new NotImplementedException();
        }

        public void ReRank()
        {
            var persons = context.Persons
                .OrderByDescending(x => x.FinalWorth)
                .ToList();

            int rank = 0;
            double prev_fw = 0;
            foreach (var person in persons)
            {
                if (person.FinalWorth != prev_fw)
                {
                    rank++;
                }
                person.Rank = rank;
                context.Persons.Update(person);
            }
            context.SaveChanges();
        }
    }
}
