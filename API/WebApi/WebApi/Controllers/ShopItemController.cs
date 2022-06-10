using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApi.Exceptions;
using WebApi.Models;
using WebApi.Services;

namespace WebApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ShopItemController : ControllerBase
    {
        private readonly ShopItemService _shopItemService;

        public ShopItemController(ShopItemService shopItemService)
        {
            _shopItemService = shopItemService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            return Ok(await _shopItemService.GetAll());
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            try
            {
                ShopItem shopItem = await _shopItemService.Get(id);
                return Ok(shopItem);
            }
            catch (ItemNotFoundException ex)
            {
                return NotFound(ex.Message);
            }

            //var shopItem = _shopItemService.Get(id);

            //if (shopItem == null)
            //{
            //    return NotFound();
            //}

            //return Ok(shopItem);
        }

        [HttpPost]
        public async Task<IActionResult> Create(ShopItem shopItem)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            await _shopItemService.Add(shopItem);
            return NoContent();
        }

        [HttpPut]
        public async Task<IActionResult> Update(ShopItem shopItem)
        {
            await _shopItemService.Update(shopItem);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Remove(int id)
        {
            await _shopItemService.Remove(id);
            return NoContent();
        }
    }
}
