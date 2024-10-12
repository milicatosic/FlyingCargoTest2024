using API.Data;
using API.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;
using Model.Entities;

namespace API.Repositories
{
    public class ProductRepository : IProductRepository
    {
        private readonly AppDbContext _context;
        public ProductRepository(AppDbContext context)
        {
            _context = context;
        }
        public void Create(Product product) => _context.Product.Add(product);
        public void Update(Product product) => _context.Product.Update(product);
        public void Delete(int productId)
        {
            var product = _context.Product.Find(productId);
            if (product != null)
                _context.Product.Remove(product);
        }
        public Product? GetById(int productId) => _context.Product.Find(productId);
        public IEnumerable<Product?> GetAll() => _context.Product.ToList();
    }
}
