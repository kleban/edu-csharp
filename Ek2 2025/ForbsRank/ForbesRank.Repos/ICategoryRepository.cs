using ForbesRank.Domain.Models;

namespace ForbesRank.Repos
{
    public interface ICategoryRepository
    {
        void Create(Category category);
        Category Get(int id);
        IEnumerable<Category> GetAll();       
        void Update(Category category);
        void Delete(int id);
    }
}
