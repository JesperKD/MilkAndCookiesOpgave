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
    public class ShoppingcartController : Controller
    {
        private ShoppingCart shoppingCart = new ShoppingCart();
        private readonly ILogger<ShoppingcartController> _logger;

        public ShoppingcartController(ILogger<ShoppingcartController> logger)
        {
            _logger = logger;
        }


        [HttpGet]
        public void Get()
        {
            HttpContext.Session.SetObjectAsJson("Cart", shoppingCart.NewShoppingCart());
        }


        [HttpGet]
        [Route("[action]")]
        public void GetCart()
        {
            var cart = HttpContext.Session.GetObjectFromJson<ShoppingCart>("Cart");

            foreach(Product product in cart.products)
            {
                Console.WriteLine(product.Name + " " + product.Price);
            }
        }
    }
}
