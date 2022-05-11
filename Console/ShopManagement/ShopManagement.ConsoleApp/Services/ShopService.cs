using ShopManagement.ConsoleApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopManagement.ConsoleApp.Services
{
    // all the logic
    public class ShopService
    {
        private List<ShopItem> _items;

        public ShopService()
        {
            _items = new List<ShopItem>();
        }

        public void Add(string name, int quantity)
        {
            ShopItem item = new ShopItem()
            {
                Name = name,
                Quantity = quantity
            };

            _items.Add(item);
        }

        public void Remove(string name)
        {
            _items.Where(i => i.Name != name).ToList();
        }

        public void Set(string name, int quantity)
        {
            var item = _items.First(i => i.Name == name);
            item.Quantity = quantity;
        }
        public List<ShopItem> Get()
        {
            return _items;
        }
    }
}
