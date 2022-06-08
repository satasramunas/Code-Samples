using ShopManagementWebApp.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopManagementWebApp.Repositories
{
    public class ShopRepository
    {
        private DataContext _dataContext;

        public ShopRepository(DataContext dataContext)
        {
            _dataContext = dataContext;
        }
    }
}
