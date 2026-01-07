
using System.Numerics;
using System.Transactions;

Console.WriteLine("Hello, World!");


List<decimal> amount = new List<decimal>();
List<string> description = new List<string>();

decimal balance = 0.00M;

bool isActive = true;

do 

{
Console.WriteLine();
Console.WriteLine("What would you like to do?");
Console.WriteLine("Add an expense (type 'add')");
Console.WriteLine("Remove an expense (type 'remove')");
Console.WriteLine("View all expenses (type 'view')");
Console.WriteLine("View total balance (type 'total')");
Console.WriteLine("Exit (type 'exit')");
Console.WriteLine();

string? response = Console.ReadLine();
response = response?.ToLower();




if (response == null)
    {
        Console.WriteLine("Invalid input. Please try again.");
        continue;
    }

//ADD TRANSACTION
else if ( response == "add")
    {
        bool validAmount = false;
        decimal addAmount;

        do
        {
            Console.WriteLine("Enter amount to add");
            string? inputAmount = Console.ReadLine();

            if(decimal.TryParse(inputAmount, out addAmount))
            {
                if(addAmount > 0)
                {
                    validAmount = true;
                }
                else
                {
                    Console.WriteLine("Amount must be greater than zero. Please try again.");
                  
                }
            }
            else
            {
                Console.WriteLine("Invalid input. Please try again.");
            }
        
        } while(!validAmount);

        amount.Add(addAmount);
        balance += addAmount;

        
        string? addDescription;

        do
        {
            Console.WriteLine("Enter description");
            addDescription = Console.ReadLine();
            if(string.IsNullOrWhiteSpace(addDescription))
            {
                Console.WriteLine("Invalid description. Please try again.");
            }
        } while(string.IsNullOrWhiteSpace(addDescription));

        description.Add(addDescription);
        Console.WriteLine($"Expense of {addAmount} with the description of {addDescription} added successfully.");
    }

//REMOVE TRANSACTION
else if (response == "remove")
    {
        if(amount.Count == 0)
         {
            Console.WriteLine("No expenses to remove.");
            continue; 
        }

        Console.WriteLine("Choose a transaction to remove: ");
        for(int i = 0; i < amount.Count; i++)
        {
            Console.WriteLine($"{i + 1} Amount: {amount[i]} - Description: {description[i]}");
        }

        string? RemoveatIndex;
    //NO NULL OR WHILESPACE
        do
        {
            RemoveatIndex = Console.ReadLine();

            if(string.IsNullOrWhiteSpace(RemoveatIndex))
            {  
               Console.WriteLine("Invalid amount. Please try again.");

            }
        } while (string.IsNullOrWhiteSpace(RemoveatIndex));
           
       int removeAmount;
        if(int.TryParse(RemoveatIndex, out removeAmount))
        {
            
            Console.WriteLine(removeAmount);
            removeAmount= removeAmount -1;
        }
        else
        {
            Console.WriteLine("Inavalid input. Please try again.");
            continue;
        }



        Console.WriteLine($"Expense removed successfully. {description[removeAmount]} at ${amount[removeAmount]} was removed.");
        balance = balance - amount[removeAmount];
        amount.RemoveAt(removeAmount);
        description.RemoveAt(removeAmount);

    }
//VIEW TRANSACTIONS
else if (response == "view")
    {
        for(int i = 0; i < amount.Count; i++)
         {
            Console.WriteLine($"Expense {amount[i]} - Description: {description[i]}");
         }
  
    }

//TOTAL BALANCE
else if(response == "total")
    {
        Console.WriteLine($"Your total balance is: {balance}");
    }

//EXIT PROGRAM
else if (response == "exit")
    {
        Console.WriteLine("Exiting the program. Goodbye!");
        isActive = false;
        break;
    }
else
    {
        Console.WriteLine("Invalid input. Please try again.");
        continue;
    }

} while (isActive == true);