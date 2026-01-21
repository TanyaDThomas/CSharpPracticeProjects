

using SimpleInventory;

Console.WriteLine("Welcome to Simple Inventory App!");

bool isActive = true;

Inventory inventory = new Inventory();

do
{
    Console.WriteLine("");
    Console.WriteLine("\nSelect an option:");
    Console.WriteLine("1. Add an Item");
    Console.WriteLine("2. Remove Item");
    Console.WriteLine("3. List Items");
    Console.WriteLine("4. Total value of inventory");
    Console.WriteLine("5. Exit");
    Console.WriteLine("");

    string? choice = Console.ReadLine();

    switch (choice)
    {
        case "1":
            inventory.AddItem();
            break;
        case "2":
            inventory.RemoveItem();
            break;
        case "3":
            inventory.ListItems();
            break;
        case "4":
            inventory.TotalValue();
            break;
        case "5":
            Console.WriteLine("Exiting the application. Goodbye!");
            isActive = false;
            break;
        default:
            Console.WriteLine("Invalid option. Please try again.");
            break;
    }

} while (isActive);


