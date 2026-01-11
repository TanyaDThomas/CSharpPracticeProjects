using System;
using System.Security.Cryptography.X509Certificates;

namespace ToDoList;

public class TaskController
{
    private static List<TaskItem> tasks = new List<TaskItem>();
    public static List<TaskItem> ViewTaskList => tasks;

    

    public TaskController()
    {
        
    }

    public void AddTask()
    {
        Console.WriteLine("Task to add: ");
        string? taskName;
         bool isCompleted = false;
        string? isCompletedInput;
        DateOnly dueDate;
        string? dueDateInput;

        do
        {
            taskName = Console.ReadLine();
            if(string.IsNullOrWhiteSpace(taskName))
            {
                Console.WriteLine("Task name cannot be empty.");
                return;     
            }

        }while(string.IsNullOrWhiteSpace(taskName));

        Console.WriteLine("Is complete? (y/n): ");
    
        isCompletedInput = Console.ReadLine();
        isCompletedInput = isCompletedInput?.ToLower();
        
        if(isCompletedInput == "y" || isCompletedInput == "yes")
        {
            isCompleted = true;
        }
        else if(isCompletedInput == "n" || isCompletedInput == "no")
        {
            isCompleted = false;
        }
        else
        {
            Console.WriteLine("Invalid input for completion status. Tasks defaulted to not completed.");
            isCompleted = false;
        }   

       
        Console.WriteLine("Due date (YYYY-MM-DD): ");
        dueDateInput = Console.ReadLine();
        
        while(!DateOnly.TryParse(dueDateInput, out dueDate))
        {
            Console.WriteLine("Invalid date format. Please enter the date in YYYY-MM-DD format: ");
            dueDateInput = Console.ReadLine();
        }
        
        TaskItem t = new TaskItem(taskName, isCompleted, dueDate);
        tasks.Add(t);
    }


    public void ViewTasks()
    {
        if(ViewTaskList.Count == 0)
        {
            Console.WriteLine("No tasks to display.");
            return;
        }
        else
        {
            Console.WriteLine("To Do List: ");
            foreach(var t in ViewTaskList)
            {
                Console.WriteLine($"- {t.Title} | Completed: {t.IsCompleted} | Due: {t.DueDate}");
            }
        }
      
    }

    public void MarkCompleted()
    {
        if(ViewTaskList.Count == 0)
        {
            Console.WriteLine("No tasks to mark as complete.");
            return;
        }

        Console.WriteLine("Choose a task to mark as complete: ");
        for(int i = 0; i < ViewTaskList.Count; i++)
        {
            Console.WriteLine($"{i+1}. {ViewTaskList[i].Title} | Completed: {ViewTaskList[i].IsCompleted} | Due: {ViewTaskList[i].DueDate}");
        }

        Console.WriteLine("Enter the task number: ");
        string? input = Console.ReadLine();
        if(!int.TryParse(input, out int taskNumber) || taskNumber < 1 || taskNumber > ViewTaskList.Count)
        {
            Console.WriteLine("Invalid task number.");
            return;
        }
       
            if(ViewTaskList[taskNumber - 1].IsCompleted == true)
                {
                    ViewTaskList[taskNumber - 1].IsCompleted = false;
                    Console.WriteLine($"Task '{ViewTaskList[taskNumber-1].Title}' marked as incomplete.");
                }
        else
        {
             ViewTaskList[taskNumber - 1].IsCompleted = true;
            Console.WriteLine($"Task '{ViewTaskList[taskNumber - 1].Title}' marked as completed.");
        }
    
    }

    public void DeleteTask()
    {
        if(ViewTaskList.Count == 0)
        {
            Console.WriteLine("No tasks to delete.");
            return;
        }

        Console.WriteLine("Choose a task to delete: ");
         for(int i = 0; i < ViewTaskList.Count; i++)
        {
            Console.WriteLine($"{i+1}. {ViewTaskList[i].Title} | Completed: {ViewTaskList[i].IsCompleted} | Due: {ViewTaskList[i].DueDate}");
        }

        Console.WriteLine("Enter the task to delete: ");
        string? input = Console.ReadLine();
        if(!int.TryParse(input, out int taskNumber) || taskNumber < 1 || taskNumber > ViewTaskList.Count)
        {
            Console.WriteLine("Invalid task number.");
            return;
        }
        else
        {
            Console.WriteLine($"Task '{ViewTaskList[taskNumber -1].Title}' has been deleted.");
            ViewTaskList.RemoveAt(taskNumber - 1);
            
        }
    }
}