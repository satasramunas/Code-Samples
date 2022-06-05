using ShopManagementWebApp.Models;
using System.Collections.Generic;

namespace ShopManagementWebApp.Dtos
{
    public class CreateShopDto
    {
        public ShopItem Item { get; set; }  // we should not expose entity. Should map to a dto and back. 

        public List<UserDto> Users { get; set; }
    }
}
