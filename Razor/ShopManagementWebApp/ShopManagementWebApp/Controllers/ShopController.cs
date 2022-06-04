using Microsoft.AspNetCore.Mvc;
using ShopManagementWebApp.Dtos;
using ShopManagementWebApp.Models;
using ShopManagementWebApp.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopManagementWebApp.Controllers
{
    public class ShopController : Controller
    {
        private ShopService _shopService;

        public ShopController(ShopService shopService)
        {
            _shopService = shopService;
        }

        public IActionResult Index()
        {
            var _items = _shopService.GetAll();
            return View(_items);
        }

        [HttpGet]
        public IActionResult Add()
        {
            CreateShopDto item = new CreateShopDto();     // previously it was ShopItem item
            return View(item);
        }

        [HttpPost]
        public IActionResult Add(CreateShopDto item)    // changed this one also
        {
            _shopService.Add(item.Item);        // and this one
            return RedirectToAction("Index");
        }

        public IActionResult Delete(string name)
        {
            _shopService.Delete(name);
            return RedirectToAction("Index");
        }
    }
}
