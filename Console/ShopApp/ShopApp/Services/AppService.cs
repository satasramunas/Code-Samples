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
        private CustomerService _customerService;
        public AppService()
        {
            _shopService = new ShopService();
            _customerService = new CustomerService();
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
                    Console.WriteLine($"{_customerService.Balance()}");
                    
                }

                else if (command.StartsWith("topup"))
                {
                    string[] splitCommand = command.Split(' ');
                    _customerService.TopUp(decimal.Parse(splitCommand[1]));
                }

                else if (command.StartsWith("show items"))
                {
                    List<CustomerItem> boughtItems = _customerService.GetBoughtItems();
                    foreach (CustomerItem item in boughtItems)
                    {
                        Console.WriteLine($"ItemName: {item.Name}");
                    }
                }

                else if (command.StartsWith("buy"))
                {
                    string[] splitCommand = command.Split(' ');
                    _customerService.Buy(splitCommand[1], int.Parse(splitCommand[2]));
                }

                else
                    Console.WriteLine("The command was not recognized!");
            }
            catch (Exception ex)
            { Console.WriteLine("Something went wrong, please check your input and try again"); }
        }
    }
}
