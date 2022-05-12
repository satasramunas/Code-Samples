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

        // use LINQ any! Record even smarter
        public void Add(string name, int quantity)
        {
            ShopItem item = new ShopItem()
            {
                Name = name,
                Quantity = quantity
            };
            if (!_items.Any(x => x.Name == name))
            {
                _items.Add(item);
            }
            else
                Console.WriteLine("This item is already on the list!");
        }

        public void Remove(string name)
        {
            _items.Where(i => i.Name != name).ToList();
        }

        public void Set(string name, int quantity)
        {
            ShopItem item = _items.First(i => i.Name == name);
            item.Quantity = quantity;
        }
        public List<ShopItem> Get()
        {
            return _items;
        }
    }
}
