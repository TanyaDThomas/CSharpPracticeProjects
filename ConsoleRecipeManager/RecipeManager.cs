using System;

namespace ConsoleRecipeManager;

public class RecipeManager
{
    private static List<Recipe> recipes = new List<Recipe>();
    public static List<Recipe> ReadRecipes => recipes;
    public RecipeManager()
    {
        
    }

    // Adda Recipe
    public void AddRecipe()
    {
        string? recipeName;
        List<string> recipeIngredients;
        string? recipeDescription;

        Console.WriteLine("Enter the name of the recipe:");
        recipeName = Console.ReadLine();
        if(string.IsNullOrWhiteSpace(recipeName))
        {
            Console.WriteLine("Recipe name cannot be empty.");
            return;
        }

        Console.WriteLine("Enter the ingredients (separated by commas):");
        string? ingredientsInput = Console.ReadLine();
        if(string.IsNullOrWhiteSpace(ingredientsInput))
        {
            Console.WriteLine("Ingredients cannot be empty");
            return;
        }

        recipeIngredients = ingredientsInput.Split(',', StringSplitOptions.RemoveEmptyEntries).Select(s => s.Trim()).ToList();

        Console.WriteLine("Enter the description of the recipe:");
        recipeDescription = Console.ReadLine();
        if(string.IsNullOrWhiteSpace(recipeDescription))
        {
            Console.WriteLine("Recipe description cannot be empty.");
            return;
        }
        Recipe r = new Recipe(recipeName, recipeIngredients, recipeDescription);
        recipes.Add(r);
        Console.WriteLine($"Recipe: {recipeName} added successfully!");
    }

    //DeleteRecipe
    public void DeleteRecipe()
    {
        Console.WriteLine("Choose a recipe to delete (Enter recipe number):");
        for(int i = 0; i < recipes.Count; i++)
        {
            Console.WriteLine($"{i+1} Recipe Name: {recipes[i].Name}");
        }

        string? input =Console.ReadLine();
        if (string.IsNullOrWhiteSpace(input) || !int.TryParse(input, out int choice) || choice < 1 || choice > recipes.Count)
        {
            Console.WriteLine("Invalid choice. Please select a valid recipe number.");
            return;
        }
        int selected = choice -= 1;

        Console.WriteLine($" You chose to delete {recipes[selected].Name}. Are you sure you want to delete it? (y/n)");
        string? confirmation = Console.ReadLine();
        confirmation = confirmation?.ToLower();
        if(string.IsNullOrWhiteSpace(confirmation) || (confirmation != "y" && confirmation != "n"))
        {
            Console.WriteLine("Invalid input. Please enter 'y' for yes or 'n' for no.");
            return;
        }

        if(confirmation == "y" || confirmation == "yes")
        {
            Console.WriteLine($"Recipe: {recipes[selected].Name} has been deleted successfully.");
            recipes.RemoveAt(selected);
            return;
        }
        else
        {
            Console.WriteLine("Deleteion cancelled.");
            return;
        }
    }

    //View mRecipes
    public void ViewRecipes()
    {
        Console.WriteLine("All Recipes: ");
        if(recipes.Count == 0)
        {
            Console.WriteLine("No recipes available.");
            return;
        }

        for(int i = 0; i < recipes.Count; i++)
        {
            Console.WriteLine($"{i+1} Recipe Name: {recipes[i].Name}");
        }

        Console.WriteLine("");
        Console.WriteLine("Which recipe would you like to view? (Enter recipe number)");

        string? input = Console.ReadLine();
        if(string.IsNullOrWhiteSpace(input) || !int.TryParse(input, out int choice) || choice < 1 || choice > recipes.Count)
        {
            Console.WriteLine("Invalid choice. Please select a valid recipe number.");
            return;
        }

        int selected = choice -= 1;

        recipes[selected].DisplayRecipe();

    }

    public void SearchByIngredient()
    {
        Console.WriteLine("Enter an ingredient to search for:");
        string? ingredientInput = Console.ReadLine();
        ingredientInput = ingredientInput?.ToLower();
        if(string.IsNullOrWhiteSpace(ingredientInput))
        {
            Console.WriteLine("Ingredient cannot be empty.");
            return;
        }

        for(int i = 0; i < recipes.Count; i++)
        {
            for(int j = 0; j < recipes[i].Ingredients.Count; j++)
            {
                if(ingredientInput == recipes[i].Ingredients[j].ToLower())
                {
                    Console.WriteLine($"Recipe found: {recipes[i].Name}");
                }
            }
        }
    }

}
