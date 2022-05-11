using ShopManagement.ConsoleApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopManagement.ConsoleApp.Services
{
    // processing of the application (the info from input/ReadLine())
    public class ApplicationService
    {
        private ShopService _shopService;
        public ApplicationService()
        {
            _shopService = new ShopService();
        }

        public void Process(string command)
        {
            if (command.StartsWith("add".Trim()))
            {
                string[] splitCommand = command.Split(' ');
                _shopService.Add(splitCommand[1], int.Parse(splitCommand[2]));
            }

            else if (command.StartsWith("remove"))
            {
                string[] splitCommand = command.Split(' ');
                _shopService.Remove(splitCommand[1]);
            }

            else if (command.StartsWith("show"))
            {
                List<ShopItem> items = _shopService.Get();
                foreach (ShopItem item in items)
                {
                    Console.WriteLine($"ItemName: {item.Name}, Quantity: {item.Quantity}");
                }
            }

            else if (command.StartsWith("set"))
            {
                string[] splitCommand = command.Split(' ');
                _shopService.Set(splitCommand[1], int.Parse(splitCommand[2]));
            }

            else if (command.StartsWith("exit"))
            {
                string[] splitCommand = command.Split(' ');
                Environment.Exit(0);
            }

            else
                Console.WriteLine("Incorrect command");
        }
    }
}
