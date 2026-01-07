# Personal Budget Tracker (C# Console App)

## 📌 Overview
**Personal Budget Tracker** is a C# console application designed to help users track their income and expenses.  
This project focuses on learning and practicing **collections in C#**, particularly **parallel lists**, and building a simple **menu-driven system** for user interaction.

The application allows users to **add transactions, remove them, view all transactions, and calculate the total balance**, while handling basic input validation.

---

## 🎯 Goal
- Deepen understanding of collections in C#  
- Practice index-based logic and loops  
- Build menu-driven console applications  
- Strengthen problem-solving with user input

---

## ✨ Features
- Add income or expenses
- Remove a transaction
- View all transactions
- View total balance
- Handles invalid input (to some extent)

---

## 🧠 Concepts Practiced
- **Parallel lists** (`List<decimal>` and `List<string>`)  
- Loops (`do-while` and `for`)  
- Index-based logic  
- Menu-driven systems  
- Basic input validation

---

## 🛠️ Tech Stack
- Language: **C#**  
- Application Type: **Console Application**  
- Framework: **.NET**  

---

## ⚠️ Known Issues / Notes
- Currently, the **Remove transaction** feature can crash if the user inputs an index of `0` or a number larger than the total number of transactions.  
  - The program currently resets to the main menu in this case.  
  - Future improvements include adding robust **bounds checking** to prevent this crash.

---

## 🚀 Stretch Goals / Future Improvements
- Add **classes** to represent transactions for cleaner code  
- Implement **persistent storage** (file or database)  
- Add categories for transactions (e.g., Food, Rent, Entertainment)  
- Summarize expenses by category  
- Add timestamps for transactions  

---

## 📈 Learning Outcome
Through this project, I practiced:
- Managing **parallel lists** and keeping data in sync  
- Handling user input carefully  
- Using **loops and conditional statements** effectively  
- Structuring menu-driven console applications  
- Debugging and understanding crash scenarios

---

## 📂 Project Status
✅ Core functionality implemented  
🔧 Remove crash and other stretch goals planned

## ⚠️ Known Issues / Notes
- **Remove transaction crash:**  
  Currently, if a user tries to remove a transaction by entering an **index of 0** or a number **larger than the total number of transactions**, the program crashes.  
  - This happens because the code does not yet check if the entered index is within the valid range before accessing the lists.  
  - Right now, when this occurs, the program returns to the main menu, allowing the user to try again.  
- **Future fix:**  
  I plan to implement **bounds checking** and proper error handling to prevent the crash and provide a friendly message if the user enters an invalid index.


