# Inventory Management System (C# Console Application)

## 📌 Overview
The **Inventory Management System** is a C# console application that simulates a simple real-world inventory workflow.  
Users can add, update, remove, and view products while the system enforces validation rules and provides low-stock warnings.

This project was built as a practice assignment to strengthen object-oriented programming concepts and business logic implementation in C#.

---

## 🎯 Project Objectives
- Model real-world inventory behavior using classes
- Apply validation and business rules
- Use enums for controlled data values
- Practice separation of responsibilities
- Build a menu-driven console application

---

## 🧩 Features
- **Add Products**
  - Enter product name, quantity, and category
  - Input validation prevents invalid entries

- **Update Product Quantity**
  - Select an existing product and update its quantity
  - Prevents negative or invalid quantities

- **Remove Products**
  - Remove items from inventory using menu selection

- **View Inventory**
  - Display all products with name, quantity, and category

- **Low-Stock Warnings**
  - Automatically warns when product quantity falls below 5

---

## 🏗️ Project Structure
InventoryManagementSystem/

│

├── Program.cs # Application entry point and menu logic

├── Inventory.cs # Inventory management and business rules

├── Product.cs # Product model

├── Category.cs # Enum defining product categories

└── README.md

---

## 🧱 Classes Overview

### `Product`
Represents a single inventory item.

**Properties**
- `Name` – Product name
- `Quantity` – Current stock level
- `Category` – Product category (enum)

**Methods**
- `UpdateQuantity(int newQuantity)` – Updates quantity with validation

---

### `Category` (Enum)
Defines allowed product categories:
- `food`
- `electronics`
- `clothing`
- `furniture`

---

### `Inventory`
Manages the list of products and all inventory-related operations.

**Responsibilities**
- Add new products
- Update product quantities
- Remove products
- Display inventory
- Trigger low-stock warnings

---

## 🧠 Concepts Practiced
- Object-Oriented Programming (OOP)
- Business rules and validation logic
- Enums for controlled input
- List and collection management
- Console menu systems
- Real-world modeling

---

## ▶️ How to Run
1. Open the project in Visual Studio or VS Code
2. Build and run the application
3. Use the menu to manage inventory items
4. Follow on-screen prompts for each action

---

## 🧪 Example Usage
- Add a product with a name, quantity, and category
- Update quantities as stock changes
- Receive warnings when stock is low
- Remove discontinued items
- View the full inventory list at any time

---

## 🚀 Future Improvements
Potential enhancements for future versions:
- Centralized product selection helper method
- Case-insensitive category handling
- Search and filter inventory
- Persistent storage (file or database)
- Configurable low-stock threshold
- Sorting by name, quantity, or category

---

## ✅ Status
**Completed**  
This project fulfills all assignment requirements and serves as a foundational example of real-world inventory modeling in C#.
