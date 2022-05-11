using System;
using ShopManagement.ConsoleApp.Services;

namespace ShopManagement.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var appService = new ApplicationService();
            while (true)
            {
                Console.WriteLine("Enter your command:");
                string command = Console.ReadLine();

                appService.Process(command);
                
            }
        }
    }
}
