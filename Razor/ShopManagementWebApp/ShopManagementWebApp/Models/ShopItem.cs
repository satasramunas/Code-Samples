using ShopManagementWebApp.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopManagementWebApp.Models
{
    public class ShopItem
    {
        public string Name { get; set; }

        public string ShopName { get; set; }

        public DateTime ExpiryDate { get; set; }

    }
}
