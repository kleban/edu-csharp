using ForbesRank.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForbesRank.Repos
{
    public interface IPersonRepository
    {
        void Create(Person person);
        Person Get(int id);
        IEnumerable<Person> GetAll();
        void Update(Person person);

        void ReRank();

        void Delete(int id);
    }
}
