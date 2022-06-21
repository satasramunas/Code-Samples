using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TodoWebApi.Helpers
{
    public static class DiscountHelper
    {
        public static decimal GetDiscountPrice(decimal price)
        {
            return 0.9M * price;
        }
    }
}
