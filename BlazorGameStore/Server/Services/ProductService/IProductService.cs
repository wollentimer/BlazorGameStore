using BlazorGameStore.Shared;

namespace BlazorGameStore.Server.Services.ProductService
{
    public interface IProductService
    {
        Task<List<Product>> GetAllProductsAsync();
        
        Task<List<Product>> GetProductsByCategoryAsync(string categoryUrl);

        Task<Product> GetProductAsync(int id);

        Task<List<Product>> SearchProducts(string searchText);

    }
}