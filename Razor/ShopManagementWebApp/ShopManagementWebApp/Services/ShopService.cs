using ShopManagementWebApp.Data;
using ShopManagementWebApp.Dtos;
using ShopManagementWebApp.Models;
using ShopManagementWebApp.Repositories;
using ShopManagementWebApp.Services.Base;
using System.Collections.Generic;
using System.Linq;

namespace ShopManagementWebApp.Services
{
    public class ShopService
    {
        private RepositoryBase<ShopItem> _shopRepository;

        public ShopService(ShopRepository shopRepository)
        {
            _shopRepository = shopRepository;
        }

        public List<ShopItem> GetAll()
        {
            return _shopRepository.GetAll();
        }

        public void Add(CreateShopDto createShopDto)
        {
            //map Dto to entity
            ShopItem item = new ShopItem
            {
                Name = createShopDto.Item.Name,
                Id = createShopDto.Item.Id
            };

            _shopRepository.Add(item);
        }
        public void Delete(int id)
        {
           _shopRepository.Delete(id);
        }
    }
}
