// See https://aka.ms/new-console-template for more information
using GuessingGame;



bool playAgain = true;
Console.WriteLine("Welcome to the Guessing Game!");
do
{
    Console.WriteLine("Please enter a number between 1 and 100");

    Random random = new Random();
    int number = random.Next(1, 101);

    for(int i = 0; i < 3; i++)
    {
        int userGuess = int.Parse(Console.ReadLine());
        Guess.IsCorrect(userGuess, number);
        Console.WriteLine($"You have {2 - i} attempts left");
        if(userGuess == number)
        {
            break;
        }
    }
    
    Console.WriteLine("Would you like to play again? (y/n)");
    string? response = Console.ReadLine();

    response = response?.ToLower();

    if(response == "y" || response == "yes")
    {
        playAgain = true;
    }
    else if(response == "n" || response == "no")
    {
        Console.WriteLine("Thank you for playing! Goodbye!");
        playAgain = false;
    }
    else
    {
        Console.WriteLine("Invalid response. Exiting the game.");
        playAgain = false;
        break;
    }
    
} while (playAgain == true);