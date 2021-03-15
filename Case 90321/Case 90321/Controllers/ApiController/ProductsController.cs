using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Case_90321.Services;
using DataModels;

namespace Case_90321.Controllers.ApiController
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {

        private readonly IProductService _productService;

        public ProductsController(IProductService productService)
        {
            _productService = productService;
        }

        // GET: api/Products
        [HttpGet("getProducts")]
        public async Task<ActionResult<IEnumerable<Product>>> GetProducts()
        {
            IEnumerable<Product> allProductsAsync = await _productService.GetAllProductsAsync();

            return Ok(allProductsAsync);
        }

        // GET: api/Products/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Product>> GetProduct(int id)
        {
            var product = await _productService.GetProduct(id);

            return product;
        }

        // PUT: api/Products/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("update/{id}")]
        public async Task<IActionResult> PutProduct(int id, Product product)
        {
            var result = await _productService.PutProduct(id, product);

            return Ok(result);
        }

        // POST: api/Products
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost("create")]
        public async Task<ActionResult<Product>> PostProduct(Product product)
        {
            await _productService.PostProduct(product);
            return CreatedAtAction("GetProduct", new { id = product.Id }, product);
        }

      // POST: api/ProductConfiguration
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost("createConfiguration")]
        public async Task<ActionResult<Product>> PostConfiguration(int productId, ProductConfiguration configuration)
        {
            await _productService.PostProductConfiguration(productId,configuration);

            return Ok();
        }

        // DELETE: api/Products/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteProduct(int id)
        {
            await _productService.DeleteProduct(id);

            return NoContent();
        }
    }
}
