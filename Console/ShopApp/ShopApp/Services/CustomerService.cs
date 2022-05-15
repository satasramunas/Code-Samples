using ShopApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopApp.Services
{
    public class CustomerService
    {
        private List<CustomerItem> _boughtItems;

        public CustomerService()
        {
            _boughtItems = new List<CustomerItem>();
        }

        public decimal GetBalance()
        {
            CustomerItem item = new CustomerItem();
            return item.Balance;
        }

        public void TopUp(decimal balance)
        {
            CustomerItem item = new CustomerItem()
            {
                Balance = balance += balance
            };
        }

        public void Buy(string name, int quantity)
        {

        }

        public List<CustomerItem> GetBoughtItems()
        {
            return _boughtItems;
        }
    }
}
