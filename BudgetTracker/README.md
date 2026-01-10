# Budget Tracker V2 (C# Console App)

## 📌 Overview
**Budget Tracker V2** is a C# console application designed to track income and expenses using **classes and object-oriented principles**.  
This project is a major turning point in my C# learning, as it introduces **classes, constructors, encapsulation, and lists of objects**, making the code cleaner and more maintainable than the previous version.

Users can **add transactions, view all transactions, and check the current balance** through a simple menu-driven interface.

---

## 🎯 Goal
- Understand **why classes exist** and how they improve code structure  
- Practice **object-oriented programming** in C#  
- Build a cleaner, more maintainable budget tracker  

---

## ✨ Features
- Add a transaction with:
  - Amount
  - Description
  - Date (automatic)
  - Type (Income or Expense)
- View all transactions
- View current balance
- Handles basic input validation:
  - Positive amounts only
  - Non-empty descriptions
  - Type must be "Income" or "Expense"
- Maintains all transactions in a single `List<Transaction>` for simplicity and clarity

---

## 🧠 Concepts Practiced
- **Classes** (`Transaction` and `Budget`)  
- **Constructors** to initialize objects  
- **Encapsulation** with read-only properties  
- **Lists of objects** to manage transactions  
- Loops and menu systems  
- Input validation and basic error handling  

💡 This project is a huge turning point in C# learning, as it transitions from procedural programming to **object-oriented programming**.

---

## 🛠️ Tech Stack
- Language: **C#**  
- Application Type: **Console Application**  
- Framework: **.NET**  

---

## 📂 Project Structure

BudgetTrackerV2/

├── Program.cs # Main program with menu

├── Budget.cs # Budget class handling transactions and balance

└── Transaction.cs # Transaction class with Amount, Description, Date, and Type

---

## ⚡ Notes
- This version improves on **Personal Finance Tracker (v1)** by using classes to make the code cleaner and easier to maintain.  
- The application currently **does not persist data**; transactions are stored in memory and lost when the program exits.  
- Future improvements could include:
  - Persistent storage (file or database)  
  - Categorizing transactions  
  - Summarizing income vs expenses  
  - Advanced error handling and reporting

---

## 📈 Learning Outcome
Through this project, I practiced:
- **Creating and using classes** in C#  
- Structuring code for **cleaner, more maintainable applications**  
- Working with **lists of objects** instead of parallel lists  
- Handling input and validating user data in a menu-driven console program  
- Understanding the value of **object-oriented design** for real-world programming

