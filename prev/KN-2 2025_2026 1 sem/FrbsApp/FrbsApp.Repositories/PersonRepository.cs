using FrbsApp.Core.Context;
using FrbsApp.Core.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace FrbsApp.Repositories
{
    public class PersonRepository : Repository<Person>, IPersonRepository
    {
        public PersonRepository(FrbsContext context): base(context)
        {
            
        }

        public IEnumerable<Person> GetAll()
        {
            return _dbSet.Include(x=> x.Category).ToList();
        }
    }
}
