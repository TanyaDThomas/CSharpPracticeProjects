using BudgetTracker;

Console.WriteLine("Hello, World!");

Budget budget = new Budget();
bool isActive = true;

Console.WriteLine("Welcome to Budget Tracker!");

while(isActive)
{
    Console.WriteLine("");
    Console.WriteLine("What would you like to do?");
    Console.WriteLine("1. Add Transaction");
    Console.WriteLine("2. View Transactions");
    Console.WriteLine("3. View Balace");
    Console.WriteLine("4. Exit");
    Console.Write("Enter your choice (1-4): ");

    string? choice = Console.ReadLine();
    if(string.IsNullOrWhiteSpace(choice) || !int.TryParse(choice, out int intChoice) || intChoice < 1 || intChoice > 3)
    {
        Console.WriteLine("Invalid choice. Please enter a number between 1 and 3.");
        continue;
    }   

    switch (intChoice)
    {
        case 1:
            budget.AddTransaction();
            break;
        case 2:
            budget.ViewTransactions();
            break;
        case 3:
            budget.ViewBalance();
            break;
        case 4:
            isActive = false;
            Console.WriteLine("Exiting Budget Tracker. Goodbye!");
            break;  
    }
}






