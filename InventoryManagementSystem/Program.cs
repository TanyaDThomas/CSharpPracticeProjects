// See https://aka.ms/new-console-template for more information
using System.Collections.Concurrent;
using InventoryManagementSystem;

Inventory inventory = new Inventory();
bool isActive = true;

Console.WriteLine("Welcome to the Inventory Management System!");

do
{
    Console.WriteLine("");
    Console.WriteLine("Choose an option: (1-5)");
    Console.WriteLine("1. Add Product");
    Console.WriteLine("2. Update Product");
    Console.WriteLine("3. Remove Product");
    Console.WriteLine("4. View Inventory");
    Console.WriteLine("5. Exit");
    Console.WriteLine("");

    string? option = Console.ReadLine();
    if(string.IsNullOrWhiteSpace(option) || !int.TryParse(option, out int choice) || choice < 1 || choice > 5)
    {
        Console.WriteLine("Invalid choice. Please enter a menu item number (1-5): ");
        continue;
    }

    switch (choice)
    {
        case 1:
            //Add Product
            inventory.AddProduct();
            break;
        case 2:
            //Update Product
            inventory.UpdateProduct();
            break;
        case 3:
            //Remove Product
            inventory.RemoveProduct();
            break;
        case 4:
            //ViewInventory
            inventory.ViewInventory();
            break;
        case 5:
            Console.WriteLine("Exiting the Inventory Management System. Goodbye!");
            isActive = false;
            break;
    }

} while (isActive);
