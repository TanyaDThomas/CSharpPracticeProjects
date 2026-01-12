using System;
using SimpleBankingSystem;

Bank bank = new Bank();

bool isActive = true;

Console.WriteLine("Welcome! Thank you for banking with us!");

Console.WriteLine("");

do
{
        
    Console.WriteLine("");
    Console.WriteLine("How can we assist you? (1-8)");
    Console.WriteLine("1. Create an account");
    Console.WriteLine("2. Find an Account");
    Console.WriteLine("3. Deposit Funds");
    Console.WriteLine("4. Withdraw Funds");
    Console.WriteLine("5. View Balance");
    Console.WriteLine("6. View Account Details");
    Console.WriteLine("7. Transfer Funds");
    Console.WriteLine("8. Exit");
    Console.WriteLine("");

    string? userInput = Console.ReadLine();

    if(string.IsNullOrEmpty(userInput) || !int.TryParse(userInput, out int choice) || choice < 1 || choice > 8)
        {
            Console.WriteLine("Invalid input. Please enter a menu item 1 through 8.");
            return;
        } 

        switch (choice)
        {
            case 1:
                // Createa n account
                bank.CreateAccount();
                break;
            case 2:
                //Find Account
                bank.FindAccount();
                break;
            case 3:
                //Deposit Funds
                bank.SelectDepositAccount();
                break;
            case 4:
                //Withdraw Funds
                bank.SelectWithdrawAccount();
                break;
            case 5:
                //View Balance
                bank.ViewBalance();
                break;
            case 6:
                //View Account Details
                bank.ViewAccounts();
                break;
            case 7:
                //Transfer Funds
                bank.TransferFunds();
                break;
            case 8:
                Console.WriteLine("Thank you for banking with us! Have a great rest of your day! Goodbye!");
                isActive = false;
                break;
        }

} while (isActive);