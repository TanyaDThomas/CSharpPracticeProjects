using System;

namespace SimpleInventory;

public class Item
{
    public string Name { get; set; } = "";
    public int Quantity { get; set;  } = 0;
    public decimal Price { get; set; } = 0;

    public Item(string name, int quantity, decimal price)
    {
        Name = name;
        Quantity = quantity;        
        Price = price;
    }
}   
