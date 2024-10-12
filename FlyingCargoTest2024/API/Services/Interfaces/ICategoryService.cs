using API.DTOs;

namespace API.Services.Interfaces
{
    public interface ICategoryService
    {
        IEnumerable<CategoryDto?> GetAllCategories();
        CategoryDto? GetCategoryById(int id);
        void CreateCategory(CategoryDto categoryDto);
        void UpdateCategory(CategoryDto categoryDto);
        void DeleteCategory(int id);
    }
}
