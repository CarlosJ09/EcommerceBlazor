using ShopOnline.Models.Dtos;
using ShopOnline_API.Entities;
using System.Runtime.CompilerServices;

namespace ShopOnline_API.Extensions
{
    public static class DtoConversions
    {
        public static IEnumerable<ProductDto> ConvertToDto(this IEnumerable<Product> products, IEnumerable<ProductCategory> productCategories)
        {
            return (from product in products
                    join ProductCategory in productCategories
                    on product.CategoryId equals ProductCategory.Id
                    select new ProductDto
                    { 
                        Id = product.Id,
                        Name= product.ProductName,
                        Description = product.ProductDescription,
                        ImageURL = product.ImageURL,
                        Price = product.Price,
                        Quantity = product.Quantity,
                        CategoryId = product.CategoryId,

                    }).ToList();
        }
    }
}
