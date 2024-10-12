using API.DTOs;

namespace API.Services.Interfaces
{
    public interface IProductCategoriesService
    {
        void CreateProductCategory(ProductCategoriesDto productCategoryDto);
        void DeleteByProductId(int productId);
        void UpdateProductCategory(ProductCategoriesDto productCategoryDto);
        ProductCategoriesDto? GetByProductId(int productId);
        IEnumerable<ProductCategoriesDto?> GetAllProductCategories();
    }
}
