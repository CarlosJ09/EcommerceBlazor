using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ShopOnline.Models.Dtos;
using ShopOnline_API.Extensions;
using ShopOnline_API.Repositories.Contracts;

namespace ShopOnline_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductRepository productRepository;
        public ProductController(IProductRepository productRepository)
        {
            this.productRepository = productRepository;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<ProductDto>>> GetItems()
        {
            try
            {
                var products = await this.productRepository.GetItems();
                var productCategories = await this.productRepository.GetCategories();

                if(products == null || productCategories == null)
                {
                    return NotFound();
                } 
                else
                {
                    var productdDtos = products.ConvertToDto(productCategories);

                    return Ok(productdDtos);
                }
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Error retrievnig data form the database");
            }
        }
    }
}
