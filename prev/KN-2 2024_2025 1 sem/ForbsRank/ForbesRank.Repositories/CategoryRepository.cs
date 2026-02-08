using ForbesRank.Domain.Context;
using ForbesRank.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForbesRank.Repositories
{
    public class CategoryRepository : ICategoryRepository
    {
        public IEnumerable<Category> GetAll()
        {
            using (var ctx = new ForbesContext())
            {
                return ctx.Categories.OrderBy(x=> x.Title).ToList();
            }
        }
    }
}
