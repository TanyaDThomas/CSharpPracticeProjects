using System;
using System.Diagnostics.CodeAnalysis;
using System.Text.Json;

namespace SimpleInventory;

public class Inventory
{
    string filePath = "inventory.json";
    private List<Item> items = new List<Item>();
    public List<Item> ReadItems => items;

    public Inventory()
    {
        LoadItems();
    }

    public void LoadItems()
    {
        // Implementation for loading items
        if(!File.Exists(filePath))
        {
            items = new List<Item>();
            return;
        }

        try
        {
            string jsonData = File.ReadAllText(filePath);
            items = JsonSerializer.Deserialize<List<Item>>(jsonData) ?? new List<Item>();
        }
        catch
        {
            Console.WriteLine("Error loading inventory data. Starting with an empty inventory.");
            items = new List<Item>();
        }
    }

    public void Save()
    {
        // Implementation for saving items
        var options = new JsonSerializerOptions
        {
            WriteIndented = true
        };

        string jsonData = JsonSerializer.Serialize(items, options);
        File.WriteAllText(filePath, jsonData);
    }

    public void AddItem()
    {
        
            Console.WriteLine("Enter item name:");
            string? name = Console.ReadLine();
            if(String.IsNullOrWhiteSpace(name))
            {
                Console.WriteLine("Item name cannot be empty. Please try again.");
                Console.WriteLine("");
                return;
            }

            Console.WriteLine("Enter item quantity:");
            string? quantityInput = Console.ReadLine();
            if(string.IsNullOrWhiteSpace(quantityInput) || !int.TryParse(quantityInput, out int quantity) || quantity < 0)
            {
                Console.WriteLine("Invalid quantity. Please enter a non-negative integer.");
                Console.WriteLine("");
                return;
            }

            Console.WriteLine("Enter item price:");
            string? priceInput = Console.ReadLine();
            if(string.IsNullOrWhiteSpace(priceInput) || !decimal.TryParse(priceInput, out decimal price) || price < 0)
            {
                Console.WriteLine("Invalid price. Please enter a non-negative decimal number.");
                Console.WriteLine("");
                return;
            }

            Item newItem = new Item(name, quantity, price);
            items.Add(newItem);
            Save();
            Console.WriteLine($"'{name}' was added successfully.");
            Console.WriteLine("");
        
            LowStockAlert();
    }

    public void RemoveItem()
    {
        if(items.Count == 0)
        {
            Console.WriteLine("Inventory is empty. No items to remove.");
            Console.WriteLine("");
            return;
        }
        Console.WriteLine("Select the item number to remove:");
        for(int i = 0; i < items.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {items[i].Name} (Quantity: {items[i].Quantity}, Price: {items[i].Price:C})");
            Console.WriteLine("");
        }

        string? input = Console.ReadLine();
        if(string.IsNullOrWhiteSpace(input) || !int.TryParse(input, out int choice) || choice < 1 || choice > items.Count)
        {
            Console.WriteLine("Invalid selection. Please try again.");
            Console.WriteLine("");
            return;
        }

        items.RemoveAt(choice - 1);
        Save();
        Console.WriteLine("Item removed successfully.");
        Console.WriteLine("");

        LowStockAlert();
    }

    public void ListItems()
    {
        if(items.Count == 0)
        {
            Console.WriteLine("Inventory is empty.");
            Console.WriteLine("");
            return;
        }
        
        Console.WriteLine("Current Inventory:");
        Console.WriteLine("");
        foreach(var item in ReadItems)
        {
            Console.WriteLine($"Name: {item.Name}, Quantity: {item.Quantity}, Price: {item.Price:C}");
            Console.WriteLine("");
        }
    }

    public void TotalValue()
    {
        if(items.Count == 0)
        {
            Console.WriteLine("Inventory is empty.");
            Console.WriteLine("");
            return;
        }

            decimal totalValue = 0;
            foreach(var item in ReadItems)
            {
                totalValue += item.Price * item.Quantity;
            }

            Console.WriteLine($"Total value of inventory: {totalValue:C}");
            Console.WriteLine("");
    }

    public void LowStockAlert(int threshhold = 5)
    {
        foreach(var item in ReadItems)
        {
            if(item.Quantity <= threshhold)
            {
                Console.WriteLine($"Alert: '{item.Name}' is low on stock. Current quantity: {item.Quantity}");
                Console.WriteLine("");  
            }
        }
    }
}