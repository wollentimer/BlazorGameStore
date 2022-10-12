using BlazorGameStore.Shared;

namespace BlazorGameStore.Client.Services.ProductService
{
    public interface IProductService
    {
        List<Product> Products { get; set; }

        void LoadProducts();
    }
}
