using ShopManagementWebApp.Data;
using ShopManagementWebApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopManagementWebApp.Services
{
    public class CategoryService
    {
        private DataContext _dataContext;

        public CategoryService(DataContext dataContext)
        {
            _dataContext = dataContext;
        }

        public void Create(Category category)
        {
            _dataContext.Categories.Add(category);
            _dataContext.SaveChanges();
        }
    }
}
