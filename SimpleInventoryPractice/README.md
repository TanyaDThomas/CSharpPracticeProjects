# Simple Inventory App

## 📌 Overview
The **Simple Inventory App** is a C# console application designed to help users manage a small inventory of items.  
Users can **add, remove, list items**, and calculate the **total value** of the inventory.  
Inventory data is **persisted to a JSON file**, allowing the application to retain state across sessions.

This project demonstrates **real-world object modeling**, input validation, and basic persistence in C#.

---

## 🎯 Project Goals
- Practice working with **classes and objects**
- Learn how to **store and manage collections of objects**
- Implement **JSON-based data persistence**
- Build a **menu-driven console application** with validation and alerts
- Handle **low-stock warnings** for inventory management

---

## ⚙️ Features
- Add new items (name, quantity, price)
- Remove existing items
- List all items with details
- Calculate the total value of the inventory
- JSON-based persistence (`inventory.json`)
- Low-stock alerts for items below a threshold (default: 5)

---

## 🧱 Project Structure

### Classes

#### `Item`
Represents an individual inventory item.

**Properties:**
- `Name` – Name of the item
- `Quantity` – Number of units in stock
- `Price` – Price per unit

---

#### `Inventory`
Handles all inventory operations.

**Responsibilities:**
- Store items in a list
- Add and remove items
- List items and calculate total value
- Persist items to a JSON file (`inventory.json`)
- Alert for low-stock items

---

## 🧠 Concepts Practiced
- Classes and objects
- Lists of objects
- Encapsulation and property validation
- JSON serialization & deserialization (`System.Text.Json`)
- Input validation and error handling
- Console menu-driven applications
- Real-world inventory modeling

---

## ▶️ How to Run
1. Open the project in **Visual Studio** or **VS Code**
2. Build and run the console application
3. Use the menu options (1–5) to manage your inventory
4. Inventory is automatically saved to `inventory.json` after changes

---

## ⚠️ Current Limitations
- Inventory is stored locally in a single JSON file
- No search or edit functionality for existing items
- Low-stock threshold is fixed but can be customized in code

---

## 🚀 Future Improvements
- Add editing capability for existing items
- Search items by name or category
- Make low-stock threshold configurable via user input
- Add categories for items
- Improve user interface for better readability
- Implement advanced reporting (e.g., highest value items, inventory summary)

---

## 💡 Why This Project Matters
This project introduces **basic inventory management**, demonstrating **object-oriented design**, **data persistence**, and **user input validation**.  
It’s a practical bridge between small console apps and larger systems like database-backed applications or ERP tools.
