# Simple Banking System (C# Console App)

## 📌 Overview
**Simple Banking System** is a C# console application that simulates basic banking operations using **multiple interacting classes**.  
This project focuses on how objects collaborate with one another, modeling real-world behavior such as managing accounts, transferring money, and enforcing account rules.

The application allows users to create bank accounts, deposit and withdraw funds, transfer money between accounts, and view account details through a menu-driven interface.

---

## 🎯 Goal
- Understand how **objects interact with other objects**
- Practice **separation of responsibility** between classes
- Model real-world systems using multiple classes
- Improve design thinking for scalable applications

---

## 🧱 Class Design

### `BankAccount`
Represents a single bank account.

**Properties**
- `Owner`
- `Balance`

**Methods**
- `Deposit(decimal amount)`
- `Withdraw(decimal amount)`

---

### `Bank`
Represents the banking system that manages accounts.

**Responsibilities**
- Store a list of `BankAccount` objects
- Create new accounts
- Find and display accounts
- Handle deposits, withdrawals, and transfers

---

## ✨ Features
- Create new bank accounts
- Find accounts by owner name
- Deposit funds into an account
- Withdraw funds from an account
- Transfer funds between accounts
- View individual account balances
- View all account details
- Input validation for menu choices and monetary values

---

## 🧠 Concepts Practiced
- **Multiple classes working together**
- **Passing objects** between methods
- **Encapsulation** and access control
- **Separation of responsibility**
- Lists of objects
- Menu-driven console applications
- Input validation and defensive programming
- Real-world system modeling

---

## 🛠️ Tech Stack
- Language: **C#**
- Application Type: **Console Application**
- Framework: **.NET**

---

## 📂 Project Structure
SimpleBankingSystem/

├── Program.cs # Main menu and application loop

├── Bank.cs # Manages accounts and banking operations

└── BankAccount.cs # Represents an individual bank account

---

## ⚠️ Notes / Current Design Decisions
- Accounts are stored in memory using a `List<BankAccount>`.
- Data is **not persisted** between application runs.
- Most menu actions require selecting an account each time.
- The application currently mixes:
  - A static account list
  - An instance-based `Bank` controller

These design choices were intentional for learning and will be refined in future versions.

---

## 🚀 Future Improvements & Refactoring Ideas
- Create a shared `SelectAccount()` helper method to reduce duplicate selection logic
- Remove unnecessary loops after an account index is selected
- Choose **either** a fully static or fully instance-based `Bank` design
- Add the ability to **focus on a single active account** with an option to switch accounts
- Improve account lookup (e.g., unique account IDs)
- Persist accounts using files or a database
- Add transaction history per account

---

## 📈 Learning Outcome
Through this project, I learned how to:
- Design systems where **objects collaborate**
- Assign responsibilities to the correct classes
- Avoid overloading a single class with too many concerns
- Think about scalability and refactoring opportunities
- Build a foundation for more realistic, production-style applications

