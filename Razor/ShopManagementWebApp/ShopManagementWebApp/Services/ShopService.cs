using ShopManagementWebApp.Data;
using ShopManagementWebApp.Models;
using System.Collections.Generic;
using System.Linq;

namespace ShopManagementWebApp.Services
{
    public class ShopService
    {
        private DataContext _dataContext;

        public ShopService(DataContext dataContext)
        {
            _dataContext = dataContext;
        }

        public List<ShopItem> GetAll()
        {
            return _dataContext.Items.ToList();
        }

        public void Add(ShopItem item)
        {
            _dataContext.Items.Add(item);
            _dataContext.SaveChanges();
        }

        public void Delete(string name)
        {
           var item = _dataContext.Items.FirstOrDefault(t => t.Name == name);
            _dataContext.Items.Remove(item);
            _dataContext.SaveChanges();
            // these lines intad of the one that's below

            //_items = _items.Where(x => x.Name != name).ToList();
        }
    }
}
