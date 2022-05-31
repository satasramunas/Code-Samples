using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopApp.Models
{
    public class CustomerItem
    {
        public decimal Balance { get; set; } = 20.0M;

        public List<ShopItem> Cart { get; set; } = new List<ShopItem>();
    }
}
