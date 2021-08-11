using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MilkAndCookiesOpgave.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CartDeleteController : Controller
    {
        private ShoppingCart shoppingCart = new ShoppingCart();
        private readonly ILogger<CartDeleteController> _logger;

        public CartDeleteController(ILogger<CartDeleteController> logger)
        {
            _logger = logger;
        }


        [HttpGet]
        public void Get()
        {
            var updated = shoppingCart.DeleteFromCart(HttpContext.Session.GetObjectFromJson<ShoppingCart>("Cart"));
            HttpContext.Session.SetObjectAsJson("Cart", updated);
        }




    }
}
