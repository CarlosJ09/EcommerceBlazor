using BlazorClient;
using BlazorClient.Services;
using BlazorClient.Services.Contratcs;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri("https://localhost:7004/") });
builder.Services.AddScoped<IProductService, ProductService>();

await builder.Build().RunAsync();
