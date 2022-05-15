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
        private CustomerItem _customer;

        public CustomerService()
        {
            _boughtItems = new List<CustomerItem>();    // we can also put this customer _boughtItems list in CustomerItem.cs
        }

        public decimal GetBalance()
        {
            return _customer.Balance;
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
