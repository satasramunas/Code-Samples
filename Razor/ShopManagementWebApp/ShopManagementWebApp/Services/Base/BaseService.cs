using ShopManagementWebApp.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopManagementWebApp.Services.Base
{
    public class BaseService<T>
        where T : class
    {
        private DataContext _dataContext;

        public BaseService(DataContext dataContext)
        {
            _dataContext = dataContext;
        }
    }
}
