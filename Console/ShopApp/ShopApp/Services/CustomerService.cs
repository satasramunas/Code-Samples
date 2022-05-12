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
    }
}
