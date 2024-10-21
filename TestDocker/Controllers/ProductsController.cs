using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TestDocker.Models;

namespace TestDocker.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public ProductsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/products
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Product>>> GetProducts()
        {
            SeedData();
            return await _context.Products.ToListAsync();
        }

        // POST: api/products
        [HttpPost]
        public async Task<ActionResult<Product>> PostProduct(Product product)
        {
            SeedData();
            _context.Products.Add(product);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetProducts), new { id = product.ProductId }, product);
        }

        [NonAction]
        public void SeedData()
        {
            _context.Database.Migrate();
            _context.Database.EnsureCreated();
            if (!_context.Products.Any())
            {
                _context.Products.AddRange(
                    new Product { Name = "Product 1", Price = 9.99m },
                    new Product { Name = "Product 2", Price = 19.99m },
                    new Product { Name = "Product 3", Price = 29.99m }
                );
                _context.SaveChanges();
            }
        }
    }
}
