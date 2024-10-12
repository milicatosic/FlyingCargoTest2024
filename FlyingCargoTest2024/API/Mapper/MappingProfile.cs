using API.DTOs;
using AutoMapper;
using Model.Entities;

namespace API.Mapper
{
    public class MappingProfile : Profile
    {
        public MappingProfile() 
        {
            CreateMap<Product, ProductDto>().ReverseMap();
            CreateMap<Category, CategoryDto>().ReverseMap();
            CreateMap<ProductCategories, ProductCategoriesDto>().ReverseMap();
        }        
    }
}
