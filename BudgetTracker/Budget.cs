using System;
using System.Reflection;

namespace BudgetTracker;

public class Budget
{

    private static List<Transaction> transactions = new List<Transaction>();
    public static List<Transaction> ViewTransList => transactions;

    decimal balance = 0.00M;
    public Budget()
    {
        
    }

    public void AddTransaction()
    {
        decimal amount;
        string? description;
        DateTime date; 
        string? type;
        bool validAmount = false;
        
        do
        {
            Console.Write("Enter the amount: ");
            string? input = Console.ReadLine();
            if (decimal.TryParse(input, out amount) && amount > 0)
            {
                validAmount = true;
            }
            else
            {
                Console.WriteLine("Invalid amount. Please enter a positive number.");
            }
         
        } while (!validAmount);


        bool isNull = false;
        do
        {
            Console.WriteLine("Enter the description: ");
            description = Console.ReadLine();

            if(string.IsNullOrWhiteSpace(description))
            {
                Console.WriteLine("Description cannot be empty. Please try again.");
            }
            else
            {
                isNull = true;
            }
        } while (!isNull);

        date = DateTime.Now;

        do
        {
            Console.WriteLine("Enter the type (Income/Expense): ");
            type = Console.ReadLine();
            type = type?.ToLower();
            if(string.IsNullOrWhiteSpace(type))
            {
                Console.WriteLine("Type cannot be empty. Please try again.");
            }
            else
            if (type != "income" && type != "expense")
            {
                Console.WriteLine("Invalid type. Please enter either 'Income' or 'Expense'.");
            }
            else
            {
                if(type == "income")
                    {
                        balance += amount;
                        break;
                    }

                if(type == "expense")
                    {
                        if(balance <= 0)
                        {
                            Console.WriteLine("Insufficient balace for this expense.");
                        }
                        
                        else
                        {
                            balance -= amount;
                            break;
                        }
                        break;
                    }
            }

        } while(true);

        Transaction t = new Transaction (amount, description, date, type);
        transactions.Add(t);
    }

    public void ViewTransactions()
    {
        if(transactions.Count == 0 )
        {
            Console.WriteLine("No transactions to display.");
        }
        else
        {
            Console.WriteLine("Transactions:");
            foreach(var t in transactions)
            {
                Console.WriteLine($"Date: {t.Date}, Amount: {t.Amount}, Description: {t.Description}. Type: {t.Type}");
            }
        }
        
    }

    public void ViewBalance()
    {
        Console.WriteLine($"Current Balance: {balance:C}");
    }
    
}
