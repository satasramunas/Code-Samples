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
        private List<ShopItem> _boughtItems;
        private CustomerItem _customer;

        public ShopService()
        {
            _items = new List<ShopItem>();
            _boughtItems = new List<ShopItem>();
            _customer = new CustomerItem();
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

        public decimal GetBalance()
        {
            return _customer.Balance;
        }

        public void TopUp(decimal money)
        {
                _customer.Balance += money;
        }

        public void Buy(string name, int quantity)
        {
            try
            {
                var item = _items.First(x => x.Name == name);
                if (item.Quantity >= quantity)
                {
                    if (item.Price * quantity <= _customer.Balance)
                    {
                        item.Quantity -= quantity;
                        _customer.Balance -= item.Price * quantity;
                        _boughtItems.Add(item);
                    }
                    else
                        Console.WriteLine("Customer does not have enaugh money");
                }
                else
                    Console.WriteLine("The shop does not have enaugh items");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Shop item not found");
            }
        }

        public List<ShopItem> GetBoughtItems()
        {
            return _boughtItems;
        }
    }
}
