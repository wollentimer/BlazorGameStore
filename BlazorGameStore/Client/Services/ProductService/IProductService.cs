using BlazorGameStore.Shared;

namespace BlazorGameStore.Client.Services.ProductService
{
    public interface IProductService
    {
        event Action OnChange;

        List<Product> Products { get; set; }

        Task LoadProductsAsync(string categoryUrl = null);

        Task<Product> GetProductAsync(int id);
    }
}
