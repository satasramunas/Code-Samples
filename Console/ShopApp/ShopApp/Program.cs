// See https://aka.ms/new-console-template for more information
using ShopApp.Services;

var appService = new AppService();
while (true)
{
    Console.WriteLine("Enter your command:");
    string command = Console.ReadLine().ToLower().Trim();

    appService.Process(command);
}
