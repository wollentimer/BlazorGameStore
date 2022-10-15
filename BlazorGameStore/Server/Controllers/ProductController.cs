using BlazorGameStore.Server.Services.ProductService;
using BlazorGameStore.Shared;
using Microsoft.AspNetCore.Mvc;

namespace BlazorGameStore.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductService _productService;

        public ProductController(IProductService productService)
        {
            _productService = productService;
        }

        [HttpGet]
        public async Task<ActionResult<List<Product>>> GetAllProductsAsync()
        {
            return Ok(await _productService.GetAllProductsAsync());
        }

        [HttpGet("Category/{categoryUrl}")]
        public async Task<ActionResult<List<Product>>> GetProductsByCategoryAsync(string categoryUrl)
        {
            return Ok(await _productService.GetProductsByCategoryAsync(categoryUrl));
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Product>> GetProductAsync(int id)
        {
            return Ok(await _productService.GetProductAsync(id));
        }

        //[HttpGet("Search/{searchText}")]
        //public async Task<ActionResult<List<Product>>> SearchProductsAsync(string searchText)
        //{
        //    return Ok(await _productService.SearchProductsAsync(searchText));
        //}
    }
}
