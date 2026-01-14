using System;

namespace ConsoleRecipeManager;

public class Recipe
{
    public string Name { get; set; }
    public List<string> Ingredients = new List<string>();
    public string Description { get; set;} 

    public Recipe(string name, List<string> ingredients, string description)
    {
        Name = name;
        Ingredients = ingredients;
        Description = description;
    }

    public void DisplayRecipe()
    {
        Console.WriteLine($" Recipe Name: {Name}");
        Console.WriteLine("==== Ingredients ====");
        foreach(var ingredient in Ingredients)
        {
            Console.WriteLine($"{ingredient}");
        }
        Console.WriteLine($"==== Description ====");
        Console.WriteLine(Description);
    }
}
