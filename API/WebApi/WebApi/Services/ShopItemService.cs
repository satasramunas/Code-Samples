using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApi.Data;
using WebApi.Exceptions;
using WebApi.Models;

namespace WebApi.Services
{
    public class ShopItemService
    {
        private readonly DataContext _dataContext;

        public ShopItemService(DataContext dataContext)
        {
            _dataContext = dataContext;
        }

        public async Task<ShopItem> Get(int id)
        {
            var shopItem = await _dataContext.ShopItems.FirstOrDefaultAsync(s => s.Id == id);

            if (shopItem == null)
            {
                throw new ItemNotFoundException();
            }

            return shopItem;
        }

        public async Task<List<ShopItem>> GetAll()
        {
            return await _dataContext.ShopItems.ToListAsync();

            // this shows why we need to use async with ToList()

            //var query = _dataContext.ShopItems.Where(x => true);
            //query = query.Where(x => x.Id > 0);

            //return await query.ToListAsync();
        }

        public async Task Add(ShopItem shopItem)
        {
            _dataContext.ShopItems.Add(shopItem);
            await _dataContext.SaveChangesAsync();
        }

        public async Task Update(ShopItem shopItem)
        {
            _dataContext.Update(shopItem);
            await _dataContext.SaveChangesAsync();
        }

        public async Task Remove(int id)
        {
            var shopItem = await Get(id);

            _dataContext.ShopItems.Remove(shopItem);
            await _dataContext.SaveChangesAsync();
        }
    }
}
