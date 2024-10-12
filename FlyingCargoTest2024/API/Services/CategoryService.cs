using API.DTOs;
using API.Repositories.UnitOfWork;
using API.Services.Interfaces;
using AutoMapper;
using Model.Entities;

namespace API.Services
{
    public class CategoryService : ICategoryService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public CategoryService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public void CreateCategory(CategoryDto categoryDto)
        {
            var category = _mapper.Map<Category>(categoryDto);
            _unitOfWork.Categories.Create(category);
            _unitOfWork.Save();
        }

        public void DeleteCategory(int id)
        {
            var category = _unitOfWork.Categories.GetById(id);
            if (category != null)
            {
                _unitOfWork.Categories.Delete(id);
                _unitOfWork.Save();
            }
        }

        public IEnumerable<CategoryDto?> GetAllCategories()
        {
            var categories = _unitOfWork.Categories.GetAll();
            return _mapper.Map<IEnumerable<CategoryDto>>(categories);
        }

        public CategoryDto? GetCategoryById(int id)
        {
            var category = _unitOfWork.Categories.GetById(id);
            return _mapper.Map<CategoryDto?>(category);
        }

        public void UpdateCategory(CategoryDto categoryDto)
        {
            var category = _mapper.Map<Category>(categoryDto);
            _unitOfWork.Categories.Update(category);
            _unitOfWork.Save();
        }
    }
}
