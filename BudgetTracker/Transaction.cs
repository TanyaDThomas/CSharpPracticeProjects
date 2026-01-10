using System;
using System.ComponentModel;

namespace BudgetTracker;

public class Transaction
{
    public decimal Amount {get; }
    public string Description { get; }
    public DateTime Date { get; }
    public string Type { get; }
    public Transaction(decimal amount, string description, DateTime date, string type)
    {
       
        Amount = amount;
        Description = description;
        Date = date;
        Type = type;
        
    }

   
}
