using ShopManagementWebApp.Data;
using ShopManagementWebApp.Models;
using ShopManagementWebApp.Services.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopManagementWebApp.Services
{
    public class CategoryService : BaseService<Category>
    {
        public CategoryService(DataContext dataContext) : base(dataContext)
        {
        }
    }
}
