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

