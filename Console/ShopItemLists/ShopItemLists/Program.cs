// See https://aka.ms/new-console-template for more information
using ShopItemLists.Models;

Console.WriteLine("Hello, World!");

List<ShopItem> shopItems = new List<ShopItem>();

shopItems.Add(new ShopItem()
{
    Name = "Ice Cream",
    Quantity = 10,
    Price = 2.2M
});
shopItems.Add(new ShopItem()
{
    Name = "Candy",
    Quantity = 3,
    Price = 0.9M
});
shopItems.Add(new ShopItem()
{
    Name = "Cake",
    Quantity = 0,
    Price = 15M
});
shopItems.Add(new ShopItem()
{
    Name = "Expired Sandwich",
    Quantity = 3,
    Price = 3M,
    Expired = true
});
shopItems.Add(new ShopItem()
{
    Name = "Expired Sandwich",
    Quantity = 3,
    Price = 3M,
    Expired = true
});

// You can not simply print complex objects (like lists)
// You have to specify what you want to print
//Console.WriteLine(shopItems);

//foreach (ShopItem item in shopItems)
//{
//    Console.WriteLine($"{item.Name} {item.Expired}");
//}

// Using LINQ
// lambda expression!
//shopItems.ForEach(item => Console.WriteLine($"{item.Name} {item.Expired}"));


// Filtering

//// Filter not expired products
//List<ShopItem> notExpiredItems = new List<ShopItem>();

//foreach (ShopItem item in shopItems)
//{
//    if (item.Expired == false)
//    {
//        notExpiredItems.Add(item);
//    }
//}

//// Filtering with LINQ
//notExpiredItems.ForEach(item => Console.WriteLine($"{item.Name} {item.Expired}"));

//List<ShopItem> notExpiredItemsWithLINQ = shopItems.Where(item => item.Expired == false).ToList();

//// The same as above
//notExpiredItemsWithLINQ.ForEach(item => Console.WriteLine($"{item.Name} {item.Expired}"));


// Select
//I want to get all unique names

//List<string> uniqueNames = new List<string>();

//foreach (ShopItem item in shopItems)
//{
//    var uniqueName = item.Name;
//    if (!uniqueNames.Contains(uniqueName))
//    {
//        uniqueNames.Add(uniqueName);
//    }
//}

//List<string> uniqueNamesWithLINQ = shopItems.Select(x => x.Name).Distinct().ToList();

//uniqueNamesWithLINQ.ForEach(name => Console.WriteLine(name));



// Functional programming

// Get the first item by name that is not expired
//ShopItem firstItem = shopItems.Where(s => !s.Expired).OrderBy(s => s.Name).First();
//Console.WriteLine(firstItem.Name);


// Get the largest quantity of an item
// There are many LINQ ways to get it
//int largestQuantity = shopItems.OrderByDescending(s => s.Quantity).Select(s => s.Quantity).First();
//Console.WriteLine(largestQuantity);


//// Chaeck if item named "Apple" exists
//bool doesExist = shopItems.Any(si => si.Name.ToLower() == "apple");

// Get first item where quantity is more than 100
ShopItem item = shopItems.Where(i => i.Quantity > 100).FirstOrDefault(); //kad grazintu null, nes First uzlauzia program

if (item != null)
{
    Console.WriteLine(item.Name);
}