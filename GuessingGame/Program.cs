
using GuessingGame;


Console.WriteLine("Welcome to the Guessing Game!");
Console.WriteLine("GamePlay Options: ");
Console.WriteLine("Easy: Guess a number between 1 and 10 with 3 attempts");
Console.WriteLine("Medium: Guess a number between 1 and 50 with 4 attempts");
Console.WriteLine("Hard: Guess a number between 1 and 100 with 5 attempts");

string? gameMode = Console.ReadLine();
gameMode = gameMode?.ToLower();
if (gameMode == "easy")
{
    Game.EasyMode();
}
else if(gameMode == "medium")
{
    Game.MediumMode();
}
else if(gameMode == "hard")
{
    Game.HardMode();
}
else
{
    Console.WriteLine("Invalid game mode selected. Please restart the game and choose a valid mode. Goodbye!");
}
