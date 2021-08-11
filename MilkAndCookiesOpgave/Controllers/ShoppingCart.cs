using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MilkAndCookiesOpgave.Controllers
{
    public class ShoppingCart
    {

        public List<Product> products { get; set; }

        public ShoppingCart NewShoppingCart()
        {
            ShoppingCart shoppingCart = new ShoppingCart();
            shoppingCart.products = new List<Product>();


            for (int i = 1; i < 11; i++)
            {
                shoppingCart.products.Add(
                    new Product()
                    {
                        Id = i,
                        Name = "Banana",
                        Price = 4
                    });
            }

            return shoppingCart;

        }

        public ShoppingCart DeleteFromCart(ShoppingCart shoppingCart)
        {
            shoppingCart.products.RemoveAt(0);

            return shoppingCart;
        }
    }
}
