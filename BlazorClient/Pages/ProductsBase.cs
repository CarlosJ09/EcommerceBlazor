using BlazorClient.Services.Contratcs;
using Microsoft.AspNetCore.Components;
using ShopOnline.Models.Dtos;

namespace BlazorClient.Pages
{
    public class ProductsBase:ComponentBase
    {
        [Inject]
        public IProductService ProductService { get; set; }

        public IEnumerable<ProductDto> Products { get; set; }

        protected override async Task OnInitializedAsync()
        {
            Products = await ProductService.GetItems();
        }
    }
}
