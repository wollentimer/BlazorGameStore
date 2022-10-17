using Blazored.LocalStorage;
using Blazored.Toast.Services;
using BlazorGameStore.Client.Services.ProductService;
using BlazorGameStore.Shared;

namespace BlazorGameStore.Client.Services.CartService
{
    public class CartService : ICartService
    {
        private readonly ILocalStorageService _localStorage;
        private readonly IToastService _toastService;
        private readonly IProductService _productService;

        public event Action OnChange;

        public CartService(
            ILocalStorageService localStorage,
            IToastService toastService,
            IProductService productService)
        {
            _localStorage = localStorage;
            _toastService = toastService;
            _productService = productService;
        }

        public async Task AddToCart(ProductVariant productVariant)
        {
            var cart = await _localStorage.GetItemAsync<List<ProductVariant>>("cart");
            if (cart == null)
            {
                cart = new List<ProductVariant>();
            }

            cart.Add(productVariant);
            await _localStorage.SetItemAsync("cart", cart);

            var product = await _productService.GetProductAsync(productVariant.ProductId);
            _toastService.ShowSuccess(product.Title, "Added to cart:");

            OnChange.Invoke();
        }

        //public async Task<List<CartItem>> GetCartItems()
        //{
        //    var cart = await _localStorage.GetItemAsync<List<CartItem>>("cart");
        //    if (cart == null)
        //    {
        //        return new List<CartItem>();
        //    }
        //    return cart;
        //}

        //public async Task DeleteItem(CartItem item)
        //{
        //    var cart = await _localStorage.GetItemAsync<List<CartItem>>("cart");
        //    if (cart == null)
        //    {
        //        return;
        //    }

        //    var cartItem = cart.Find(x => x.ProductId == item.ProductId && x.EditionId == item.EditionId);
        //    cart.Remove(cartItem);

        //    await _localStorage.SetItemAsync("cart", cart);
        //    OnChange.Invoke();
        //}

        //public async Task EmptyCart()
        //{
        //    await _localStorage.RemoveItemAsync("cart");
        //    OnChange.Invoke();
        //}
    }
}
