using ShopOnline.Models.Dtos;

namespace BlazorClient.Services.Contratcs
{
    public interface IProductService
    {
        Task<IEnumerable<ProductDto>> GetItems();
    }
}
