using System;
using System.Net;
using System.Runtime.InteropServices.Marshalling;

namespace GuessingGame;

public class Guess
{


    public Guess()
    {
        
    }

    public static void IsCorrect(int userGuess, int number)
    {
        if(userGuess == number)
        {
            Console.WriteLine($"Congratulations! You guessed the correct number: {number}");
            return;
        }
        else if(userGuess < number)
        {
            Console.WriteLine("Your guess is too low. Please try again.");
            
        }
        else if(userGuess > number)
        {
            Console.WriteLine("Your guess is too high. Please try again.");
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter a valid number. Goodbye!");
        }
    }
}
