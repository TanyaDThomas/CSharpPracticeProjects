# Number Guessing Game 🎯

## Overview
This is a console-based **Number Guessing Game** written in C#. The game is designed to practice **loops, conditionals, random number generation, and user input handling**. Players try to guess a randomly generated number within a limited number of attempts. The game provides feedback after each guess and includes difficulty levels, attempt countdowns, and a play-again option.

---

## Features

### Random Number Generation
- The game generates a random number for the player to guess.
- The range depends on the selected difficulty level.

### Difficulty Levels
Players can choose from three difficulty levels:

| Level  | Number Range | Maximum Attempts |
|--------|--------------|----------------|
| Easy   | 1 – 10       | 5 – 7          |
| Medium | 1 – 50       | 7 – 10         |
| Hard   | 1 – 100      | 10 – 12        |

### Guess Feedback
- After each guess, the game tells the player whether the guess is:
  - **Too high**
  - **Too low**
  - **Correct**
- The game also displays how many **attempts remain** after each guess.

### Input Validation
- Ensures the player enters a valid number.
- Prevents invalid input from counting as an attempt.

### Play Again Option
- Players can choose to play again after finishing a game.
- Input can be `y`/`yes` to continue or `n`/`no` to exit.

---

## How to Play

1. Run the game in a C# console environment (Visual Studio, VS Code, or `dotnet run`).
2. Select a difficulty level: `Easy`, `Medium`, or `Hard`.
3. Enter your guess when prompted.
4. The game provides feedback and shows remaining attempts.
5. Continue guessing until you either guess correctly or run out of attempts.
6. After the game ends, choose to play again or quit.

---

## Example Gameplay

Welcome to the Guessing Game!
GamePlay Options:
Easy: Guess a number between 1 and 10 with 3 attempts
Medium: Guess a number between 1 and 50 with 4 attempts
Hard: Guess a number between 1 and 100 with 5 attempts

Medium
Please enter a number between 1 and 50
25
Your guess is too low. Please try again.
You have 3 attempts left

40
Your guess is too high. Please try again.
You have 2 attempts left

33
Congratulations! You guessed the correct number: 33

Would you like to play again? (y/n)

n
Thank you for playing! Goodbye!


---

## Project Structure

- `Program.cs` – Handles the main program flow and user input for difficulty selection.  
- `Game.cs` – Contains static methods for each difficulty level, loops for attempts, and play-again logic.  
- `Guess.cs` – Contains the `IsCorrect` method to check player guesses and provide feedback.  

---

## Concepts Practiced
- Loops (`for` and `do-while`)  
- Conditionals (`if-else`)  
- Random number generation (`Random`)  
- User input parsing (`int.Parse`)  
- Modular class design and static methods  
- Difficulty levels and attempt tracking  

---

## Stretch Ideas (Optional)
- Add additional difficulty levels or custom ranges.  
- Track and display player guess history.  
- Add hints for the player after incorrect guesses.  
- Implement a scoring system based on remaining attempts.  

---

## How to Run
1. Clone the repository:  
```bash
git clone https://github.com/YourUsername/NumberGuessingGame.git
