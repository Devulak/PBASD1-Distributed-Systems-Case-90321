using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Case_90321.Data;
using DataModels;
using Microsoft.EntityFrameworkCore;

namespace Case_90321.Services
{
    public class ProductService : IProductService
    {
        private readonly ApplicationDbContext _context;
        public ProductService(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Product>> GetAllProductsAsync()
        {
            return await _context.Products.ToListAsync();
        }

        public async Task<Product> GetProduct(int id)
        {
            var product = await _context.Products.FindAsync(id);

            return product;
        }

        public async Task<bool> PutProduct(int id, Product product)
        {
            if (id != product.Id)
            {
                return false;
            }

            _context.Entry(product).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
                return true;
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ProductExists(id))
                {
                    return false;
                }

                throw;
            }
        }

        public async Task PostProduct(Product product)
        {
            _context.Products.Add(product);

            await _context.SaveChangesAsync();
        }

        public async Task DeleteProduct(int id)
        {
            var product = await _context.Products.FindAsync(id);
            if (product == null)
            {
                return;
            }

            _context.Products.Remove(product);
            await _context.SaveChangesAsync();
        }

        public async Task PostProductConfiguration(int productId, ProductConfiguration configuration)
        {
            if (configuration == null) throw new NullReferenceException("Configuration was null");

            var product = await GetProduct(productId);

            if (product == null)
            {
                throw new NullReferenceException($"Product with ID : {productId} could not be found");
            }

            product.ProductConfigurations.ToList().Add(configuration);

            await _context.SaveChangesAsync();
        }

        private bool ProductExists(int id)
        {
            return _context.Products.Any(e => e.Id == id);
        }
    }
}
