// See https://aka.ms/new-console-template for more information
using System.Reflection.Metadata;
using ContactMangementSystem;

Console.WriteLine("Welcome to the Contact Management System!");

bool exit = false;

ContactManager Manager = new ContactManager();

do
{
    Console.WriteLine("");
    Console.WriteLine("What would you like to do? (1-6)");
    Console.WriteLine("1. Add a new contact");
    Console.WriteLine("2. Remove a contact");
    Console.WriteLine("3. List all contacts");
    Console.WriteLine("4. Save contacts to JSON");
    Console.WriteLine("5. Load contacts from JSON");
    Console.WriteLine("6. Exit");
    Console.WriteLine("");

    string? option = Console.ReadLine();
    if(string.IsNullOrWhiteSpace(option) || !int.TryParse(option, out int choice) || choice < 1 || choice > 6)
    {
        Console.WriteLine("Invalid option. Please try again.");
        continue;
    }

    switch (choice)
    {
        case 1:
            // Add a new contact
            Manager.AddContact();
            break;
        case 2:
            // Remove a contact
            Manager.RemoveContact();
            break;
        case 3:
            // List all contacts
            Manager.ListContacts();
            break;
        case 4:
            // Save contacts to JSON
            
            Manager.SaveToJson();
            break;  
        case 5:
            // Load contacts from JSON
             
             Manager.LoadFromJson();
            break;
        case 6:
            Console.WriteLine("Exiting the program. Goodbye!");
            exit = true;
            break;
    }

} while (!exit);