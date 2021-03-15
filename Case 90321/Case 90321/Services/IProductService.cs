using System.Collections.Generic;
using System.Threading.Tasks;
using DataModels;
using Microsoft.AspNetCore.Mvc;

namespace Case_90321.Services
{
    public interface IProductService
    {
        public Task<IEnumerable<Product>> GetAllProductsAsync();

        public Task<Product> GetProduct(int id);

        public Task<bool> PutProduct(int id, Product product);

        public Task PostProduct(Product product);

        public Task DeleteProduct(int id);

        public Task PostProductConfiguration(int productId, ProductConfiguration configuration);
    }
}
