using Model.Entities;

namespace API.Repositories.Interfaces
{
    public interface IProductRepository
    {
        void Create(Product product);
        void Update(Product product);
        void Delete(int productId);
        Product? GetById(int productId);
        IEnumerable<Product?> GetAll();
    }
}
