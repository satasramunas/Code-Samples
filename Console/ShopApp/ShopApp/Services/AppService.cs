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
            }
            catch (Exception ex)
            { Console.WriteLine("Please check your input and try again"); }

            try
            {
                if (command.StartsWith("remove"))
                {
                    string[] splitCommand = command.Split(' ');
                    _shopService.Remove(splitCommand[1]);
                }
            }
            catch (Exception ex)
            { Console.WriteLine("Please try again"); }

            try
            {
                if (command.StartsWith("show inventory"))
                {
                    List<ShopItem> items = _shopService.GetShopItems();
                    if (items.Count > 0)
                    {
                        foreach (ShopItem item in items)
                        {
                            Console.WriteLine($"ItemName: {item.Name}, Price: {item.Price}, Quantity: {item.Quantity}");
                        }
                    }
                    else
                        Console.WriteLine("The shop has no items");
                }
            }
            catch (Exception ex)
            { Console.WriteLine("Try again"); }

            try
            {
                if (command.StartsWith("set"))
                {
                    string[] splitCommand = command.Split(' ');
                    _shopService.Set(splitCommand[1], int.Parse(splitCommand[2]));
                }
            }
            catch (Exception ex)
            { Console.WriteLine("Please check your input and try again"); }

            if (command.StartsWith("show items"))
            {
                List<CustomerItem> boughtItems = _customerService.GetBoughtItems();
                if (boughtItems.Count > 0)
                {
                    foreach (CustomerItem item in boughtItems)
                    {
                        Console.WriteLine($"ItemName: {item.Name}");
                    }
                }
                else
                    Console.WriteLine("The customer hasn't bought anything yet");
            }
        
                
            if (command.StartsWith("exit"))
            {
                Environment.Exit(0);
            }

            if (command.StartsWith("show balance"))
            {
                Console.WriteLine($"{_customerService.GetBalance()}");

            }

            if (command.StartsWith("topup"))
            {
                string[] splitCommand = command.Split(' ');
                _customerService.TopUp(decimal.Parse(splitCommand[1]));
            }

            if (command.StartsWith("buy"))
            {
                string[] splitCommand = command.Split(' ');
                _customerService.Buy(splitCommand[1], int.Parse(splitCommand[2]));
            }

        }
    }
}


