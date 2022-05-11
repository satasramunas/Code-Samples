using ShopManagement.ConsoleApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopManagement.ConsoleApp.Services
{
    public class ApplicationService
    {
        private ShopService _shopService;
        public ApplicationService()
        {
            _shopService = new ShopService();
        }

        public void Process(string command)
        {
            if (command.StartsWith("Add".ToLower()))
            {
                string[] splitCommand = command.Split(" ");

                _shopService.Add(splitCommand[1], int.Parse(splitCommand[2]));
            }
            else if (command.StartsWith("Remove".ToLower()))
            {
                string[] splitCommand = command.Split(" ");
                _shopService.Remove(splitCommand[1]);
            }
            else if (command.StartsWith("Show".ToLower()))
            {
                List<ShopItem> items = _shopService.Get();
                foreach (ShopItem item in items)
                {
                    Console.WriteLine($"ItemName: {item.Name}, Quantity: {item.Quantity}");
                }
            }
            else if (command.StartsWith("Exit".ToLower()))
            {
                string[] splitCommand = command.Split(" ");
                Environment.Exit(0);
            }
            else
                Console.WriteLine("Incorrect command");
        }
    }
}
