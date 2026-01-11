
using ToDoList;
using System;

Console.WriteLine("Hello, World!");

// TaskItem task1 = new TaskItem("Finish homework", false, new DateOnly(2026, 12, 31));
TaskController task = new TaskController();

bool isActive = true;

Console.WriteLine("Welcome to the To-Do List Application");

do
{
    Console.WriteLine("");
    Console.WriteLine("Please select an option: (1-5)");
    Console.WriteLine("1. Add Task");
    Console.WriteLine("2. View Tasks");
    Console.WriteLine("3. Mark Task as Completed");
    Console.WriteLine("4. Delete Task");
    Console.WriteLine("5. Exit");
    Console.WriteLine("");

    string? userInput = Console.ReadLine();
    if(string.IsNullOrWhiteSpace(userInput) || !int.TryParse(userInput, out int option))
    {
        Console.WriteLine("Invalid input. Please try again.");
        continue;
    }

    switch (option)
    {
        case 1:
            Console.WriteLine("Add a Task:");
            task.AddTask();
            break;
        case 2:
            Console.WriteLine("View Tasks: ");
            task.ViewTasks();
            break; 
        case 3:
            Console.WriteLine("Mark Task as Completed: ");
            task.MarkCompleted();
            break; 
        case 4:
            Console.WriteLine("Delete a Task: ");     
            task.DeleteTask();     
            break;
        case 5:
            Console.WriteLine("Exiting the application. Goodbye!");
            isActive = false;
            break;  

    }

    
} while(isActive);


