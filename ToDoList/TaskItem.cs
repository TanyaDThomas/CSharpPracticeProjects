using System;

namespace ToDoList;

public class TaskItem
{
    public string Title { get; set;}
    public bool IsCompleted { get; set;}
    public DateOnly DueDate { get; set; }

    public TaskItem(string title, bool isCompleted, DateOnly dueDate)
    {
        Title = title;
        IsCompleted = isCompleted;
        DueDate = dueDate; 
    }
}
