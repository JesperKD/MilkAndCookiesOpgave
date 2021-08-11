using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MilkAndCookiesOpgave
{
    public class FavouriteMilkshake
    {
        public FavouriteMilkshake(string taste)
        {
            Taste = taste;
        }

        public string Taste { get; set; }
    }
}
