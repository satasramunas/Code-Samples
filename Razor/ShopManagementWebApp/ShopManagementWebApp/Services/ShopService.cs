using ShopManagementWebApp.Models;
using System.Collections.Generic;
using System.Linq;

namespace ShopManagementWebApp.Services
{
    public class ShopService
    {

        private List<ShopItem> _items = new List<ShopItem>
        {
            new ShopItem()
            {
                Name = "Butter",
                ExpiryDate = System.DateTime.Now.AddMonths(2),
                ShopName = "Butter shop"
            }
        };

        public List<ShopItem> GetAll()
        {
            return _items.OrderBy(i => i.ExpiryDate).ToList();
        }

        public void Add(ShopItem item)
        {
            _items.Add(item);
        }

        public void Delete(string name)
        {
            _items = _items.Where(x => x.Name != name).ToList();
        }
    }
}
