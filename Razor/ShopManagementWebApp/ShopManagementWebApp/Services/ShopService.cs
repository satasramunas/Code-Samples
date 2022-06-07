using ShopManagementWebApp.Data;
using ShopManagementWebApp.Models;
using System.Collections.Generic;
using System.Linq;

namespace ShopManagementWebApp.Services
{
    public class ShopService
    {
        private DataContext _dataContext;

        public ShopService(DataContext dataContext) // if we forget this, dataContext will be null (error thrown)
        {
            _dataContext = dataContext;
            // when we register our service in startup, we put it in here
            // through dependency injection
        }

        public List<ShopItem> GetAll()
        {
            return _dataContext.Items.ToList();
        }

        public void Add(ShopItem item)
        {
            item.ExpiryDate = System.DateTime.Now;
            _dataContext.Items.Add(item);
            _dataContext.SaveChanges();
        }

        public void Delete(string name)
        {
           var item = _dataContext.Items.FirstOrDefault(t => t.Name == name);
            _dataContext.Items.Remove(item);
            _dataContext.SaveChanges();
            // these lines instead of the one that's below

            //_items = _items.Where(x => x.Name != name).ToList();
        }
    }
}
