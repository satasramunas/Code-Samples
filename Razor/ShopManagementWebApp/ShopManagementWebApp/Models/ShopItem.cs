using ShopManagementWebApp.Models.Base;
using ShopManagementWebApp.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopManagementWebApp.Models
{
    public class ShopItem : NamedEntity
    {
        public string ShopName { get; set; }

        public bool Deleted { get; set; } = false;

        public User User { get; set; }

        public int? UserId { get; set; }    // the ? means that the UserId can be nullable. ShopItem gali nepriklausyti useriui.
    }
}
