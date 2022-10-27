using Blazored.LocalStorage;
using Blazored.Toast;
using BlazorGameStore.Client.Services.BlogService;
using BlazorGameStore.Client.Services.CartService;
using BlazorGameStore.Client.Services.CategoryService;
using BlazorGameStore.Client.Services.ProductService;
using BlazorGameStore.Client.Services.StatsService;
using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;

namespace BlazorGameStore.Client
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var builder = WebAssemblyHostBuilder.CreateDefault(args);
            builder.RootComponents.Add<App>("#app");
            builder.RootComponents.Add<HeadOutlet>("head::after");
            builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });
            
            builder.Services.AddScoped<IProductService, ProductService>();
            builder.Services.AddScoped<ICategoryService, CategoryService>();
            builder.Services.AddScoped<ICartService, CartService>();
            builder.Services.AddScoped<IStatsService, StatsService>();
            builder.Services.AddScoped<IBlogService, BlogService>();
            builder.Services.AddScoped<AuthenticationStateProvider, CustomAuthStateProvider>();
            
            builder.Services.AddBlazoredLocalStorage();
            builder.Services.AddBlazoredToast();
            builder.Services.AddOptions();
            builder.Services.AddAuthorizationCore();

            await builder.Build().RunAsync();
        }
    }
}