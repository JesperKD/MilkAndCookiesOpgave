using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MilkAndCookiesOpgave.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class FavoriteMilkshakeController : ControllerBase
    {
        private readonly ILogger<FavoriteMilkshakeController> _logger;

        public FavoriteMilkshakeController(ILogger<FavoriteMilkshakeController> logger)
        {
            _logger = logger;
        }


        [HttpGet]
        public void Get(string faveMilkshake)
        {
            if (faveMilkshake != null)
            {
                Response.Cookies.Append("FavoriteMilkshake", faveMilkshake);

                new CookieOptions
                {
                    Expires = DateTimeOffset.Now.AddMinutes(-5)
                };
            }
        }


        [HttpGet]
        [Route("[action]")]
        public string GetFromCookie()
        {
            var cookie = Request.Cookies["favoriteMilkshake"];
            if(cookie != null)
            {
                Console.WriteLine(cookie);
                return cookie;
            }
            return string.Empty;
        }



    }
}
