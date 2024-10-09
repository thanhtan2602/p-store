using Microsoft.AspNetCore.Mvc;

namespace Store.API.Controllers
{
    [Route("api/[controller]")]
    public class ProductController : Controller
    {
        private readonly IProductService _productService;

        public MovieController(IProductService productService)
        {
            _productService = productService;
        }

        [HttpGet("Get")]
        public IActionResult GetProducts()
        {
            var productList = _productService.GetAllProduct();
            return Ok(productList);
        }
    }
}
