using ForbesRank.Domain.Context;
using ForbesRank.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForbesRank.Repos
{
    public class CategoryRepository : ICategoryRepository
    {
        private ForbesContext context;

        public CategoryRepository(ForbesContext context)
        {
            this.context = context ?? throw new ArgumentNullException(nameof(context));
        }
        public void Create(Category category)
        {
            context.Categories.Add(category);   
            context.SaveChanges();
        }

        public void Delete(int id)
        {
            var obj = context.Categories.Find(id);
            context.Categories.Remove(obj);
            context.SaveChanges();
        }

        public Category Get(int id)
        {
            return context.Categories.Find(id);
        }

        public IEnumerable<Category> GetAll()
        {
            return context.Categories.ToList();
        }

        public void Update(Category category)
        {
            var editObj = context.Categories.Find(category.Id);
            if(editObj.Title != category.Title)
                {
                editObj.Title = category.Title;
                context.SaveChanges();
            }            
        }
    }
}
