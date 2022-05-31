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
        private CustomerItem _customer;

        public ShopService()
        {
            _items = new List<ShopItem>();
            _customer = new CustomerItem();
        }

        public void Add(string name, decimal price, int quantity)
        {
            if (_items.Any(x => x.Name == name))
            {
                throw new ArgumentException("This item is already in the inventory");
            }
            ShopItem item = new ShopItem // the brackets are not needed anymore if we use this syntax
            {
                Name = name,
                Price = price,
                Quantity = quantity
            };

            _items.Add(item);
        }

        public void Remove(string name)
        {
            if (!_items.Any(x => x.Name == name))
            {
                throw new ArgumentException("The item does not exist");
            }
            _items = _items.Where(x => x.Name != name).ToList();
        }

        public void Set(string name, int quantity)
        {
            ShopItem item = _items.FirstOrDefault(x => x.Name == name); //using LINQ to select the item by name
            
            if (item == null)
            {
                throw new ArgumentException("Item does not exist");
            }

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
            var item = _items.FirstOrDefault(x => x.Name == name);

            if (item == null)
            {
                throw new ArgumentException("Item does not exist");
            }

            decimal price = item.Price * quantity;

            if (price > _customer.Balance)
            {
                throw new ArgumentException("The customer does not have enough money");
            }

            if (quantity > item.Quantity)
            {
                throw new ArgumentException("The shop does not have enough of the required items");
            }

            item.Quantity -= quantity;
            _customer.Balance -= price;

            _customer.Cart.Add(new ShopItem
            {
                Name = item.Name,
                Price = item.Price,
                Quantity = quantity,
            });
        }

        public List<ShopItem> GetBoughtItems()
        {
            return _customer.Cart;
        }
    }
}
