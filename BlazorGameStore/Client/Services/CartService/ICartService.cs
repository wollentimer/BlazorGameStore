using BlazorGameStore.Shared;

namespace BlazorGameStore.Client.Services.CartService
{
    public interface ICartService
    {
        event Action OnChange;

        Task AddToCart(ProductVariant item);

        Task<List<CartItem>> GetCartItems();

        Task DeleteItem(CartItem item);
        //Task EmptyCart();
    }
}
