using ShopManagementWebApp.Models;
using System.Collections.Generic;

namespace ShopManagementWebApp.Dtos
{
    public class CreateShopDto
    {
        public ShopItem Item { get; set; }

        public List<User> Users { get; set; }
    }
}
