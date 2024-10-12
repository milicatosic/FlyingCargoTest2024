using API.Data;
using API.Repositories.Interfaces;
using Model.Entities;

namespace API.Repositories
{
    public class CategoryRepository :  ICategoryRepository
    {
        private readonly AppDbContext _context;

        public CategoryRepository(AppDbContext context)
        {
            _context = context;
        }

        public void Create(Category category) => _context.Category.Add(category);
        public void Update(Category category) => _context.Category.Update(category);
        public void Delete(int categoryId)
        {
            var category = _context.Category.Find(categoryId);
            if (category != null)
                _context.Category.Remove(category);
        }
        public Category? GetById(int categoryId) => _context.Category.Find(categoryId);
        public IEnumerable<Category?> GetAll() => _context.Category.ToList();
    }
}
