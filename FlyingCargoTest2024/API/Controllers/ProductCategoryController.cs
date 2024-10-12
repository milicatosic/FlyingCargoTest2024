using API.DTOs;
using API.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Model.Entities;

namespace API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProductCategoryController : ControllerBase
    {
        private readonly IProductCategoriesService _productCategoriesService;

        public ProductCategoryController(IProductCategoriesService productCategoriesService)
        {
            _productCategoriesService = productCategoriesService;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            var productCategories = _productCategoriesService.GetAllProductCategories();
            return Ok(productCategories);
        }

        [HttpGet("{productId}")]
        public IActionResult GetByProduct(int productId)
        {
            var productCategory = _productCategoriesService.GetByProductId(productId);
            if (productCategory == null)
            {
                return NotFound();
            }
            return Ok(productCategory);
        }

        [HttpPost]
        public IActionResult Create([FromBody] ProductCategoriesDto productCategoryDto)
        {
            _productCategoriesService.CreateProductCategory(productCategoryDto);
            return CreatedAtAction(nameof(GetByProduct), new { productId = productCategoryDto.ProductId, categoryId = productCategoryDto.CategoryId }, productCategoryDto);
        }

        [HttpDelete("{productId}")]
        public IActionResult Delete(int productId)
        {
            _productCategoriesService.DeleteByProductId(productId);
            return NoContent();
        }
    }
}
