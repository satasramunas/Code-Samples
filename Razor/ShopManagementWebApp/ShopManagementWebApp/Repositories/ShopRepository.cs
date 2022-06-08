using ShopManagementWebApp.Data;
using ShopManagementWebApp.Models;
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

        public List<ShopItem> GetAll()
        {
            return _dataContext.Items.ToList();
        }

        public void Add(ShopItem entity)
        {
            entity.ExpiryDate = DateTime.Now;
            _dataContext.Set<ShopItem>().Add(entity);
            _dataContext.SaveChanges();
        }

        public void Delete(int id)
        {
            var item = _dataContext.Items.FirstOrDefault(t => t.Id == id);
            _dataContext.Items.Remove(item);
            _dataContext.SaveChanges();
            // these lines instead of the one that's below

            //_items = _items.Where(x => x.Name != name).ToList();
        }
    }
}
