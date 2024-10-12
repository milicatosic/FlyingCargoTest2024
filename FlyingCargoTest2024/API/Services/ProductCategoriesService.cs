using API.DTOs;
using API.Repositories.UnitOfWork;
using API.Services.Interfaces;
using AutoMapper;
using Model.Entities;

namespace API.Services
{
    public class ProductCategoriesService : IProductCategoriesService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public ProductCategoriesService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public void CreateProductCategory(ProductCategoriesDto productCategoryDto)
        {
            var productCategories = _mapper.Map<ProductCategories>(productCategoryDto);
            _unitOfWork.ProductCategories.Create(productCategories);
            _unitOfWork.Save();
        }

        public void DeleteByProductId(int productId)
        {
            var productCategories = _unitOfWork.ProductCategories.GetByProductId(productId);
            if (productCategories != null)
            {
                _unitOfWork.ProductCategories.DeleteByProductId(productId);
                _unitOfWork.Save();
            }
        }

        public IEnumerable<ProductCategoriesDto?> GetAllProductCategories()
        {
            var productCategories = _unitOfWork.ProductCategories.GetAll();
            return _mapper.Map<IEnumerable<ProductCategoriesDto?>>(productCategories);
        }

        public ProductCategoriesDto? GetByProductId(int productId)
        {
            var productCategories = _unitOfWork.ProductCategories.GetByProductId(productId);
            return _mapper.Map<ProductCategoriesDto?>(productCategories);
        }

        public void UpdateProductCategory(ProductCategoriesDto productCategoryDto)
        {
            var productCategory = _mapper.Map<ProductCategories>(productCategoryDto);
            _unitOfWork.ProductCategories.Update(productCategory);
            _unitOfWork.Save();
        }
    }
}
