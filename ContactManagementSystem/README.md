# Contact Management System

## 📌 Overview
The **Contact Management System** is a C# console application that allows users to manage a list of contacts by adding, removing, viewing, and serializing them to JSON.  
This project focuses on modeling real-world data, managing collections of objects, and introducing **JSON serialization** using `System.Text.Json`.

Contacts are stored **in memory only**, with JSON used to demonstrate saving and loading data during runtime.

---

## 🎯 Project Goals
- Practice working with **collections of objects**
- Learn how to **serialize and deserialize data** using JSON
- Improve separation of responsibilities between classes
- Build a structured, menu-driven console application

---

## ⚙️ Features
- Add new contacts (name, phone number, email)
- Remove existing contacts
- List all saved contacts
- Serialize contacts to JSON
- Deserialize and display contacts from JSON
- Input validation to prevent invalid data

---

## 🧱 Project Structure

### Classes

#### `Contact`
Represents an individual contact.

**Properties:**
- `Name`
- `Phone`
- `Email`

---

#### `ContactManager`
Handles all contact-related operations.

**Responsibilities:**
- Store contacts in a list
- Add and remove contacts
- Display contacts
- Serialize contacts to JSON
- Deserialize contacts from JSON

This class acts as a **manager/service layer**, keeping logic separate from the UI.

---

## 🧠 Concepts Practiced
- Classes and objects
- Lists of objects
- Encapsulation
- Input validation
- JSON serialization & deserialization (`System.Text.Json`)
- Separation of concerns
- Menu-driven console applications

---

## ▶️ How to Run
1. Open the project in **Visual Studio** or **VS Code**
2. Build and run the console application
3. Use the menu options (1–6) to manage contacts

---

## ⚠️ Current Limitations
- Contacts are not saved to a file (JSON exists only in memory)
- JSON data is lost when the application exits
- No duplicate contact checking
- No search or edit functionality

---

## 🚀 Future Improvements
- Save JSON data to a file and load it on startup
- Add search by name, phone, or email
- Prevent duplicate contacts
- Add contact editing functionality
- Improve error handling and user feedback
- Refactor JSON logic into a dedicated persistence service

---

## 💡 Why This Project Matters
This project marks an important step toward **real-world application development**, introducing data persistence concepts and preparing the foundation for future projects involving databases, APIs, or file storage.
