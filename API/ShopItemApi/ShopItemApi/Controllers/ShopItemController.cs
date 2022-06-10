using Microsoft.AspNetCore.Mvc;
using ShopItemApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopItemApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ShopItemController : ControllerBase
    {
        private List<ShopItem> _shopItems = new List<ShopItem>()
        {
            new ShopItem() { Id = 1, Name = "Candy" },
            new ShopItem() { Id = 2, Name = "Popcorn" }
        };

        [HttpGet]
        public List<ShopItem> GetAll()
        {
            return _shopItems;
        }

        [HttpGet("{id}")]
        public ShopItem GetById(int id)
        {
            return _shopItems.FirstOrDefault(si => si.Id == id);
        }

        [HttpPost]
        public void Create(ShopItem shopItem)
        {
            _shopItems.Add(shopItem);
        }

        [HttpDelete("{id}")]
        public List<ShopItem> Remove(int id)
        {
            _shopItems = _shopItems.Where(si => si.Id != id).ToList();
            return _shopItems;
        }
    }
}
