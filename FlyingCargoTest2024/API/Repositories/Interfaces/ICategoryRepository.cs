using Model.Entities;

namespace API.Repositories.Interfaces
{
    public interface ICategoryRepository
    {
        void Create(Category category);
        void Update(Category category);
        void Delete(int categoryId);
        Category? GetById(int categoryId);
        IEnumerable<Category?> GetAll();
    }
}
