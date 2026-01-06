using System;

namespace GuessingGame;

public class Game
{

    public Game()
    {
        
    }


    public static void EasyMode()
    {
        bool playAgain = true;
        do
        {
            Console.WriteLine("Please enter a number between 1 and 10");

            Random random = new Random();
            int number = random.Next(1, 11);

            for(int i = 0; i < 3; i++)
            {
                int userGuess = int.Parse(Console.ReadLine());
                Guess.IsCorrect(userGuess, number);
                if(userGuess != number)
                {
                    Console.WriteLine($"You have {2 - i} attempts left");
                }
                
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
    }

        
        public static void MediumMode()
    {
        bool playAgain = true;
        do
        {
            Console.WriteLine("Please enter a number between 1 and 50");

            Random random = new Random();
            int number = random.Next(1, 51);

            for(int i = 0; i < 4; i++)
            {
                int userGuess = int.Parse(Console.ReadLine());
                Guess.IsCorrect(userGuess, number);
                if(userGuess != number)
                {
                    Console.WriteLine($"You have {3 - i} attempts left");
                }
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
    }


    public static void HardMode()
    {
        bool playAgain = true;
        do
        {
            Console.WriteLine("Please enter a number between 1 and 100");

            Random random = new Random();
            int number = random.Next(1, 101);

            for(int i = 0; i < 5; i++)
            {
                int userGuess = int.Parse(Console.ReadLine());
                Guess.IsCorrect(userGuess, number);
                if(userGuess != number)
                {
                    Console.WriteLine($"You have {4 - i} attempts left");
                }
                
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
    }
}
        
