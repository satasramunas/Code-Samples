using ShopApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopApp.Services
{
    public class AppService
    {
        private ShopService _shopService;
        public AppService()
        {
            _shopService = new ShopService();
        }

        public void Process(string command)
        {
            try
            {
                if (command.StartsWith("add"))
                {
                    string[] splitCommand = command.Split(' ');
                    _shopService.Add(splitCommand[1], decimal.Parse(splitCommand[2]), int.Parse(splitCommand[3]));
                }

                else if (command.StartsWith("remove"))
                {
                    string[] splitCommand = command.Split(' ');
                    _shopService.Remove(splitCommand[1]);
                }

                else if (command.StartsWith("show inventory"))
                {
                    List<ShopItem> items = _shopService.GetShopItems();
                    foreach (ShopItem item in items)
                    {
                        Console.WriteLine($"ItemName: {item.Name}, Price: {item.Price}, Quantity: {item.Quantity}");
                    }
                }

                else if (command.StartsWith("set"))
                {
                    string[] splitCommand = command.Split(' ');
                    _shopService.Set(splitCommand[1], int.Parse(splitCommand[2]));
                }

                else if (command.StartsWith("exit"))
                {
                    Environment.Exit(0);
                }

                else if (command.StartsWith("show balance"))
                {
                    string[] splitCommand = command.Split(' ');
                }

                else if (command.StartsWith("topup"))
                {

                }

                else if (command.StartsWith("show items"))
                {

                }

                else if (command.StartsWith("buy"))
                {

                }

                else
                    Console.WriteLine("The command was not recognized!");
            }
            catch (Exception ex)
            { Console.WriteLine("Something went wrong, please check your input and try again"); }
        }
    }
}
