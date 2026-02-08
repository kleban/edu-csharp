using ForbesRank.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForbesRank.Repositories
{
    public interface IPersonRepository
    {
        IEnumerable<Person> GetAll();
        Person Get(int id);
        int Add(Person person);
        void Delete(int id);
        void Update(Person person);
    }
}
