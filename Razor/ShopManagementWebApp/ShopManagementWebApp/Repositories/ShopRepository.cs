using ShopManagementWebApp.Data;
using ShopManagementWebApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopManagementWebApp.Repositories
{
    public class ShopRepository : RepositoryBase<ShopItem>
    {
        public ShopRepository(DataContext dataContext)
        {
        }
    }
}
