// See https://aka.ms/new-console-template for more information
using System;
using ConsoleRecipeManager;

Console.WriteLine("Welcome to the Recipe Manager!");
Console.WriteLine("");

RecipeManager recipeManager = new RecipeManager();
bool isActive = true;

do
{
    Console.WriteLine("");
    Console.WriteLine("What would you like to do? (1-3)");
    Console.WriteLine("1. Add Recipe");
    Console.WriteLine("2. Delete Recipe");
    Console.WriteLine("3. View Recipes");
    Console.WriteLine("4. Search by Ingredient");
    Console.WriteLine("5. Exit");
   
        string? option = Console.ReadLine();
        if(string.IsNullOrWhiteSpace(option) || !int.TryParse(option, out int choice) || choice < 1 || choice > 5)
        {
            Console.WriteLine("Invalid Choice. Please selecte a valid option (1-5)");
            continue;
        }
    


    switch (choice)
    {
        case 1:
            //Add Recipe
            recipeManager.AddRecipe();
            break;
        case 2:
            //Delete Recipe
            recipeManager.DeleteRecipe();
            break;
        case 3:
            //View Recipes
            recipeManager.ViewRecipes();
            break;  
        case 4:
            //Search by Ingredient
            recipeManager.SearchByIngredient();
            break;
        case 5:
            Console.WriteLine("Exiting the Recipe Manager. Goodbye!");
            isActive = false;
            break;
    }

} while (isActive);