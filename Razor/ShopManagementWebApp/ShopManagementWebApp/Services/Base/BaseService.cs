using ShopManagementWebApp.Data;
using ShopManagementWebApp.Models.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopManagementWebApp.Services.Base
{
    public class BaseService<T>
        where T : Entity
    {
        protected DataContext _dataContext;

        public BaseService(DataContext dataContext)
        {
            _dataContext = dataContext;
        }

        public void Create(T entity)
        {
            entity.ExpiryDate = DateTime.Now;
            _dataContext.Set<T>().Add(entity);
            _dataContext.SaveChanges();
        }
    }
}
