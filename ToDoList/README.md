# To-Do List Manager (C# Console App)

## 📌 Overview
**To-Do List Manager** is a C# console application built to practice **real-world modeling with classes** and object behavior.  
This project focuses on how objects **change state over time**, particularly through boolean logic and user-driven actions.

Users can create tasks, mark them as completed or incomplete, view tasks, and delete tasks through a simple menu-driven interface.

---

## 🎯 Goal
- Understand **object behavior** and how state changes over time
- Practice mutating objects stored in collections
- Model real-world concepts using classes
- Build cleaner and more maintainable menu systems

---

## ✨ Features
- Add tasks with:
  - Title
  - Completion status
  - Due date
- View all tasks
- Mark tasks as completed or incomplete
- Delete tasks
- Input validation for:
  - Empty task titles
  - Invalid menu selections
  - Invalid task indexes
  - Incorrect date formats

---

## 🧠 Concepts Practiced
- **Object state** (`IsCompleted`)
- **Boolean logic**
- **Mutating objects** in a collection
- Classes and constructors
- Lists of objects
- Index-based selection
- Menu-driven console applications
- Input validation and defensive programming

---

## 🛠️ Tech Stack
- Language: **C#**
- Application Type: **Console Application**
- Framework: **.NET**

---

## 📂 Project Structure
ToDoListManager/

├── Program.cs # Main menu and application loop

├── TaskItem.cs # Task model (Title, IsCompleted, DueDate)

└── TaskController.cs # Handles task creation, updates, and deletion


---

## ⚡ Notes
- Tasks are stored in memory using a `List<TaskItem>`.  
- Data is **not persisted** between runs — tasks are lost when the program exits.  
- Tasks can be toggled between completed and incomplete, demonstrating object state mutation.

---

## 🚀 Possible Future Improvements
- Persist tasks using a file or database
- Separate views for:
  - Pending tasks
  - Completed tasks
- Add task priority levels
- Allow editing task details
- Sort tasks by due date

---

## 📈 Learning Outcome
Through this project, I practiced:
- Modeling real-world data using classes
- Understanding how **object state changes** affect program behavior
- Writing cleaner, more maintainable logic using controllers
- Managing and mutating objects stored in collections
- Building structured, user-friendly console menus

