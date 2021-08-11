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
    public class CookieBakerController : Controller
    {
        private readonly ILogger<CookieBakerController> _logger;

        public CookieBakerController(ILogger<CookieBakerController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public void Get()
        {
            Response.Cookies.Append("BakedCookie", "Fresh cookie right out of the oven");
        }
    }
}
