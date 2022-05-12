using ShopApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopApp.Services
{
    // all the logic
    public class ShopService
    {
        private List<ShopItem> _items;

        public ShopService()
        {
            _items = new List<ShopItem>();
        }

        public void Add(string name, decimal price, int quantity)
        {
            ShopItem item = new ShopItem()
            {
                Name = name,
                Price = price,
                Quantity = quantity
            };
            if (!_items.Any(x => x.Name == name))
            {
                _items.Add(item);
            }
            else
                Console.WriteLine("This item is already in the inventory list!");
        }

        public void Remove(string name)
        {
            _items = _items.Where(x => x.Name != name).ToList();
        }

        public void Set(string name, int quantity)
        {
            ShopItem item = _items.First(x => x.Name == name); //using LINQ to select the item by name
            item.Quantity = quantity;
        }

        public List<ShopItem> GetShopItems()
        {
            return _items;
        }
    }
}
