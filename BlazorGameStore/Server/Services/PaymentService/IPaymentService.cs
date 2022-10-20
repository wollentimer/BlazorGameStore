using BlazorGameStore.Shared;
using Stripe.Checkout;

namespace BlazorGameStore.Server.Services.PaymentService
{
    public interface IPaymentService
    {
        Session CreateCheckoutSession(List<CartItem> cartItems);
    }
}
