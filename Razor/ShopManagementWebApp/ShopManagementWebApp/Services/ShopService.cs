using ShopManagementWebApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopManagementWebApp.Services
{
    public class ShopService
    {
        public ShopService()
        {
        }

        private List<Shop> _items = new List<Shop>()
        {
            new Shop()
            {
                Name = "Butter",
                ExpiryDate = System.DateTime.Now.AddMonths(2),
                ShopName = "Butter shop"
            }
        };

        public List<Shop> GetAll()
        {
            return _items;
        }

        public void Add(Shop item)
        {
            _items.Add(item);
        }

        public void Delete(string name)
        {
            _items = _items.Where(x => x.Name != name).ToList();
        }
    }
}
