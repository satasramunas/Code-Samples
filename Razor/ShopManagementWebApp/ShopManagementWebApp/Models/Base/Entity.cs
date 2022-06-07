using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopManagementWebApp.Models.Base
{
    public abstract class Entity
    {
        public int Id { get; set; }

        public DateTime ExpiryDate { get; set; }
    }
}
