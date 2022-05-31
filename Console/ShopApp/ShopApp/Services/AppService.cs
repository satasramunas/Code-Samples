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
        private readonly ShopService _shopService = new ShopService(); // don't need the constructor anymore

        public void Process(string command)
        {
            try
            {
                string[] splitCommand = command.Split(' ');

                if (command.StartsWith("add"))
                {
                    _shopService.Add(splitCommand[1], decimal.Parse(splitCommand[2]), int.Parse(splitCommand[3]));
                }
                else if (command.StartsWith("remove"))
                {
                    _shopService.Remove(splitCommand[1]);
                }
                else if (command.StartsWith("show inventory"))
                {
                    List<ShopItem> items = _shopService.GetShopItems(); // gets all the information

                    items.ForEach(i => Console.WriteLine(i.ToString())); // writes the information
                }
                else if (command.StartsWith("set"))
                {
                    _shopService.Set(splitCommand[1], int.Parse(splitCommand[2]));
                }
                else if (command.StartsWith("buy"))
                {
                    _shopService.Buy(splitCommand[1], int.Parse(splitCommand[2]));
                }
                else if (command.StartsWith("topup"))
                {
                    _shopService.TopUp(decimal.Parse(splitCommand[1]));
                }
                else if (command.StartsWith("show balance"))
                {
                    var balance = _shopService.GetBalance();
                    Console.WriteLine($"Balance: {balance}");
                }
                else if (command.StartsWith("show items"))
                {
                    var items = _shopService.GetBoughtItems();
                    items.ForEach(i => Console.WriteLine(i.ToString()));
                }
                else if (command.StartsWith("exit"))
                {
                    Environment.Exit(0);
                }
            }

            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (FormatException ex)
            {
                Console.WriteLine("Somethings wrong with your parameters");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Something wrong has happened!");
            } 
        }
    }
}


