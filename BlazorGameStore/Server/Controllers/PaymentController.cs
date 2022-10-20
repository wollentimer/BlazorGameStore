using BlazorGameStore.Server.Services.PaymentService;
using BlazorGameStore.Shared;
using Microsoft.AspNetCore.Mvc;

namespace BlazorGameStore.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PaymentController : Controller
    {
        private readonly IPaymentService _paymentService;

        public PaymentController(IPaymentService paymentService)
        {
            _paymentService = paymentService;
        }

        [HttpPost("checkout")]
        public ActionResult CreateCheckoutSession(List<CartItem> cartItems)
        {
            var session = _paymentService.CreateCheckoutSession(cartItems);
            return Ok(session.Url);
        }
    }
}
