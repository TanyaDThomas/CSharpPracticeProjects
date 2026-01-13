using System;

namespace InventoryManagementSystem;



public class Inventory
{
    private List<Product> products = new List<Product>();
    public List<Product> ReadProducts => products;
    public Inventory()
    {
        
    }

    public void AddProduct()
    {
        
        string? name;
        int quantity;
        Category category;

            Console.WriteLine($"Enter name of product to add: ");
            name = Console.ReadLine();
            if(string.IsNullOrWhiteSpace(name))
            {
                Console.WriteLine("Invalid name. Please enter a valid product name.");
                return;
            }

            Console.WriteLine($"Enter quantity of product to add: ");
            string? qtyInput = Console.ReadLine();

            if(string.IsNullOrWhiteSpace(qtyInput) || !int.TryParse(qtyInput, out quantity) || quantity <= 0)
            {
                Console.WriteLine("Invalid quantity. Please enter a valid number.");
                return;
            }

            Console.WriteLine($"Enter category of poduct to add (food, electronics, clothing, furniture): ");

            string? categoryInput = Console.ReadLine();
            if(string.IsNullOrWhiteSpace(categoryInput) || !Enum.TryParse(categoryInput, out category))
            {
                Console.WriteLine("Invalid category. Please enter a valid category.");
                return;
            }   
        
            Product newProduct = new Product(name, quantity, category);
            products.Add(newProduct);
            Console.WriteLine($"Product {name} added successfully.");

            Console.WriteLine("");
            LowStockWarning();
        
    }

    public void UpdateProduct()
    {
        Console.WriteLine("Choose an item number to update:");
        for(int i = 0; i < ReadProducts.Count; i++)
        {
            Console.WriteLine($"{i+1}  Product: {ReadProducts[i].Name}  Quantity: {ReadProducts[i].Quantity}  Category: {ReadProducts[i].Category}");
        }

        string? input = Console.ReadLine();
        if(string.IsNullOrWhiteSpace(input) || !int.TryParse(input, out int choice) || choice < 1 || choice > ReadProducts.Count)
        {
            Console.WriteLine("Invalid choice. Please enter a valid item number.");
            return;
        }

        choice -= 1;

            Console.WriteLine("Enter new quantity: ");
            string? newQtyInput = Console.ReadLine();
            if(string.IsNullOrWhiteSpace(newQtyInput) || !int.TryParse(newQtyInput, out int newQty) || newQty < 0)
            {
                Console.WriteLine("Invalid quantity. Please enter a valid number.");
                return;
            }

            ReadProducts[choice].UpdateQuantity(newQty);
            Console.WriteLine("Quantity update successfully.");
        
            Console.ReadLine();
           
    }

    public void RemoveProduct()
    {
        Console.WriteLine("Choose an item number to remove: ");
        for(int i = 0; i < ReadProducts.Count; i++)
        {
            Console.WriteLine($"{i+1}  Product: {ReadProducts[i].Name}  Quantity: {ReadProducts[i].Quantity}  Category: {ReadProducts[i].Category}");
        }

        string? input = Console.ReadLine();
        if(string.IsNullOrWhiteSpace(input) || !int.TryParse(input, out int choice) || choice < 1 || choice > ReadProducts.Count)
        {
            Console.WriteLine("Invalid choice. Please enter a valid item number.");
            return;
        }
        choice -= 1;

        ReadProducts.RemoveAt(choice);
        Console.WriteLine("Product removed successfully.");
        Console.WriteLine("");

         LowStockWarning();
    }

    public void ViewInventory()
    {
        if(ReadProducts.Count == 0)
        {
            Console.WriteLine("Inventory is empty.");
            return; 
        }

        Console.WriteLine("Current Inventory:");
        for(int i =0; i < ReadProducts.Count; i++)
        {
            Console.WriteLine($"{i+1}  Name: {ReadProducts[i].Name}  Quantity: {ReadProducts[i].Quantity}  Category: {ReadProducts[i].Category}");
        }

        Console.WriteLine("");

      
    }

    public void LowStockWarning()
    {
        foreach(var product in ReadProducts)
        {
            if(product.Quantity < 5)
            {
                Console.WriteLine($"Warning: Low stock for product {product.Name}. Current quantity: {product.Quantity}");
            }
        }
    }

}
