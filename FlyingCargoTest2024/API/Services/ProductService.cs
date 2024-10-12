using API.DTOs;
using API.Repositories.UnitOfWork;
using API.Services.Interfaces;
using AutoMapper;
using Model.Entities;

namespace API.Services
{
    public class ProductService : IProductService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public ProductService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public void CreateProduct(ProductDto productDto)
        {
            var product = _mapper.Map<Product>(productDto);
            _unitOfWork.Products.Create(product);
            _unitOfWork.Save();
        }

        public void DeleteProduct(int id)
        {
            var product = _unitOfWork.Products.GetById(id);
            if (product != null) 
            {
                _unitOfWork.Products.Delete(id);
                _unitOfWork.Save();
            }
        }

        public IEnumerable<ProductDto?> GetAllProducts()
        {
            var products = _unitOfWork.Products.GetAll();
            return _mapper.Map<IEnumerable<ProductDto>>(products);
        }

        public ProductDto? GetProductById(int id)
        {
            var product = _unitOfWork.Products.GetById(id);
            return _mapper.Map<ProductDto>(product);
        }

        public void UpdateProduct(ProductDto productDto)
        {
            var product = _mapper.Map<Product>(productDto);
            _unitOfWork.Products.Update(product);
            _unitOfWork.Save();
        }
    }
}
