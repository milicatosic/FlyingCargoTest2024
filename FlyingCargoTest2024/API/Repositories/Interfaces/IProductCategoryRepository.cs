using Model.Entities;

namespace API.Repositories.Interfaces
{
    public interface IProductCategoryRepository
    {
        void Create(ProductCategories productCategory);
        void DeleteByProductId(int productId);
        void Update(ProductCategories productCategory);
        ProductCategories? GetByProductId(int productId);
        IEnumerable<ProductCategories?> GetAll();
    }
}
