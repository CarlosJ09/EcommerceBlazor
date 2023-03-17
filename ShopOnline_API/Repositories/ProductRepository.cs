using Microsoft.EntityFrameworkCore;
using ShopOnline_API.Entities;
using ShopOnline_API.Repositories.Contracts;

namespace ShopOnline_API.Repositories
{
    public class ProductRepository : IProductRepository
    {
        private readonly ShopOnlineDbContext shopOnlineDbContext;

        public ProductRepository(ShopOnlineDbContext shopOnlineDbContext)
        {
            this.shopOnlineDbContext = shopOnlineDbContext;
        }
        public async Task<IEnumerable<ProductCategory>> GetCategories()
        {
            var categories = await this.shopOnlineDbContext.ProductCategory.ToListAsync();

            return categories;
        }

        public Task<IEnumerable<ProductCategory>> GetCategory(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Product>> GetItem(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Product>> GetItems()
        {
            var products = await this.shopOnlineDbContext.Product.ToListAsync();

            return products;
        }
    }
}
