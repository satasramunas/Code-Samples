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
        private UserService _userService;

        public ShopController(ShopService shopService, UserService userService)
        {
            _shopService = shopService;
            _userService = userService; //injected userService
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
            item.Users = _userService.GetAll();           // add this after injection, because the model was empty previously
            return View(item);
        }

        [HttpPost]
        public IActionResult Add(CreateShopDto createItem)    // changed this one also
        {
            _shopService.Add(createItem);        // and this one
            return RedirectToAction("Index");
        }

        public IActionResult Delete(int id)
        {
            _shopService.Delete(id);
            return RedirectToAction("Index");
        }

        // controllers not necessarily have to have references
    }
}
