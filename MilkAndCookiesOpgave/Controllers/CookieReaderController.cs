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
    public class CookieReaderController : Controller
    {
        private readonly ILogger<CookieReaderController> _logger;

        public CookieReaderController(ILogger<CookieReaderController> logger)
        {
            _logger = logger;
        }


        [HttpGet]
        public string Get()
        {
            var cookie = Request.Cookies["BakedCookie"];
            if (cookie != null)
            {
                Console.WriteLine(cookie);
                return cookie;
            }
            return string.Empty;
        }
    }
}
