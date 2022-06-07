using ShopManagementWebApp.Data;
using ShopManagementWebApp.Dtos;
using ShopManagementWebApp.Models;
using ShopManagementWebApp.Services.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopManagementWebApp.Services
{
    public class UserService : BaseService<User>
    {
        public UserService(DataContext dataContext) : base(dataContext)
        {
            _dataContext = dataContext;
        }

        public List<UserDto> GetAll()
        {
            var entities = _dataContext.Users.ToList();     // uzkraunam is DB

            // tada mappinam i DTO, kur bus man reikalinga info
            // cia susikursim kiekvienam entity nauja UserDto
            var dtos = entities.Select(x => new UserDto
            {
                Id = x.Id,
                FullName = $"{x.FirstName} {x.LastName}"
            }).ToList();

            return dtos;
        }
    }
}
