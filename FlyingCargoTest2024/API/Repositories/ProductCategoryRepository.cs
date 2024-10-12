using API.Data;
using API.Repositories.Interfaces;
using Model.Entities;

namespace API.Repositories
{
    public class ProductCategoryRepository : IProductCategoryRepository
    {
        private readonly AppDbContext _context;

        public ProductCategoryRepository(AppDbContext context)
        {
            _context = context;
        }

        public void Create(ProductCategories productCategory) => _context.ProductCategories.Add(productCategory);
        public void DeleteByProductId(int productId)
        {
            var productCategory = _context.ProductCategories.FirstOrDefault(pc => pc.ProductId == productId);
            if (productCategory != null)
                _context.ProductCategories.Remove(productCategory);
        }
        public ProductCategories? GetByProductId(int productId) =>
           _context.ProductCategories.Where(pc => pc.ProductId == productId).FirstOrDefault();
            
        public void Update(ProductCategories productCategory) =>_context.ProductCategories.Update(productCategory);

        public IEnumerable<ProductCategories?> GetAll() => _context.ProductCategories.ToList();  
    }
}
