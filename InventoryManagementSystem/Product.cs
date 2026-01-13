using System;
using System.ComponentModel;

namespace InventoryManagementSystem;

public class Product
{
    public string Name { get; }
    public int Quantity { get; set;}
    public Category Category { get; }

    public Product(string name, int quantity, Category category)
    {
        Name = name;
        Quantity = quantity;
        Category = category;
    }

    public void UpdateQuantity(int newQuantity)
    {
        if(newQuantity == 0)
        {
            Console.WriteLine("Quantity cannot be zero.");
            return;
        }

        Quantity = newQuantity;
    }

}
