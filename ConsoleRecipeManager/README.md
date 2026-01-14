# Console-Based Recipe Manager (C# Console Application)

## 📌 Overview
The **Console-Based Recipe Manager** is a C# console application that allows users to create, view, delete, and search recipes entirely in memory.  
Each recipe contains a name, a list of ingredients, and preparation instructions, demonstrating how real-world data can be modeled using classes and collections.

This project serves as a strong foundation for more advanced applications, such as a full-featured recipe or herbal management system.

---

## 🎯 Project Objectives
- Practice working with lists inside classes
- Implement a manager/service pattern
- Build a menu-driven console application
- Model real-world data structures
- Reinforce clean separation of responsibilities

---

## 🧩 Features
- **Add Recipes**
  - Enter recipe name, ingredients, and description
  - Ingredients are stored as a list of strings

- **View Recipes**
  - Display all saved recipes
  - View full recipe details including ingredients and instructions

- **Delete Recipes**
  - Select and remove recipes with confirmation

- **Search by Ingredient**
  - Find recipes containing a specific ingredient

- **In-Memory Data Storage**
  - All data persists only during runtime (no files or database)

---

## 🏗️ Project Structure
ConsoleRecipeManager/

│

├── Program.cs # Application entry point and menu loop

├── RecipeManager.cs # Manages recipe operations

├── Recipe.cs # Recipe model

└── README.md

---

## 🧱 Classes Overview

### `Recipe`
Represents a single recipe.

**Properties**
- `Name` – Recipe name
- `Ingredients` – List of ingredients (`List<string>`)
- `Description` – Recipe instructions or notes

**Methods**
- `DisplayRecipe()` – Displays full recipe details in the console

---

### `RecipeManager`
Handles all recipe-related operations and acts as a service layer.

**Responsibilities**
- Add new recipes
- View stored recipes
- Delete recipes
- Search recipes by ingredient
- Manage the in-memory recipe list

---

## 🧠 Concepts Practiced
- Lists inside classes
- Object-oriented design
- Manager/service pattern
- Console input validation
- Nested loops
- Real-world application modeling

---

## ▶️ How to Run
1. Open the project in Visual Studio or VS Code
2. Build and run the application
3. Use the menu options to manage recipes
4. Follow on-screen prompts for each action

---

## 🧪 Example Usage
- Add a recipe with multiple ingredients
- View all available recipes
- Display full recipe instructions
- Search for recipes by a specific ingredient
- Delete recipes you no longer need

---

## 🚀 Future Improvements
Possible enhancements for future versions:
- Case-insensitive ingredient searching
- Partial ingredient matching
- Recipe categories or tags
- Persistent storage (file or database)
- Edit existing recipes
- Improved search results display

---

## ✅ Status
**Completed**  
This project meets all assignment requirements and provides a strong bridge toward more advanced recipe and data-driven applications.

