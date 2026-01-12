using System;
using System.Buffers;

namespace SimpleBankingSystem;

public class Bank
{
    private static List<BankAccount> accounts = new List<BankAccount>();

  

    public static List<BankAccount> ReadAccounts => accounts;

   

    public void CreateAccount()
    {
        string?  owner;
        decimal amount;
        bool isValid = true;
        
        do
        {
                Console.WriteLine("Enter account owner's name: ");
                owner = Console.ReadLine();
                if(string.IsNullOrEmpty(owner))
                {
                    Console.WriteLine("Invalid name. Account creation failed.");
                    return;
                }

                Console.WriteLine("Enter inital deposit amount: ");
                string? inputAmount = Console.ReadLine();

                if(string.IsNullOrWhiteSpace(inputAmount) || !decimal.TryParse(inputAmount, out amount) || amount <= 0)
                {
                    Console.WriteLine("Invalid amount. Please enter a positive number.");
                    isValid = false;
                    return;
                }
    
          
          } while (!isValid);

        BankAccount newAccount = new BankAccount(owner, amount);
        accounts.Add(newAccount);

        Console.WriteLine($"Account for {owner} created successfully with initial balance of {amount:C}.");

        
    }

    public void FindAccount()
    {
        Console.WriteLine("Enter the name of the account owner.");
        string? ownerName = Console.ReadLine();

        if(string.IsNullOrWhiteSpace(ownerName))
        {
            Console.WriteLine("Invalid name input.");
            return;
        }

        for(int i = 0; i < ReadAccounts.Count; i++)
        {
            if(ReadAccounts[i].Owner == ownerName)
            {
                Console.WriteLine($"Account found: Owner: {ReadAccounts[i].Owner} Balance: {ReadAccounts[i].Balance} ");
                
            }
            else if(ReadAccounts[i].Owner != ownerName)
            {
                Console.WriteLine("Account not found.");
                break;
            }
        }
    }

    public void ViewAccounts()
    {
        if(ReadAccounts.Count == 0)
        {
            Console.WriteLine("No accounts found in the system.");
            return;
        }

        Console.WriteLine("Here are all the accounts in the system:");
        Console.WriteLine("");
        foreach(var account in ReadAccounts)
        {
            Console.WriteLine($"{ReadAccounts.IndexOf(account)+1} Account Owner: {account.Owner} Balance: {account.Balance}");
        }
    
    }

    public void SelectWithdrawAccount()
    {
        Console.WriteLine("Choose an account to withdraw from:");

        for(int i = 0; i < ReadAccounts.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {ReadAccounts[i].Owner} - Balance: {ReadAccounts[i].Balance:C}");
        }

        string? selectedInput = Console.ReadLine();

        if(string.IsNullOrWhiteSpace(selectedInput) || !int.TryParse(selectedInput, out int selectedAccount) || selectedAccount < 1 || selectedAccount > ReadAccounts.Count)
        {
            Console.WriteLine("Invalid selection.");
            return;
        }

        selectedAccount -= 1;
        for(int i = 0; i < ReadAccounts.Count; i++)
        {
            if(i == selectedAccount)
            {
                Console.WriteLine("Enter amount to withdraw: ");
                string? inputWithdraw = Console.ReadLine();

                if(string.IsNullOrWhiteSpace(inputWithdraw) || !decimal.TryParse(inputWithdraw, out decimal withdrawAmount) || withdrawAmount <= 0)
                {
                    Console.WriteLine("Invalid withdrawal amount.");
                    return;
                }

                ReadAccounts[i].Withdraw(withdrawAmount);
                Console.WriteLine($"Withdrawal of {withdrawAmount:C} successful. New balance: {ReadAccounts[i].Balance:C}");
            }
        }
        
    }


    public void SelectDepositAccount()
    {
        Console.WriteLine("Choose an account to deposit into: ");

        for(int i = 0; i < ReadAccounts.Count; i++)
        {
            Console.WriteLine($"{i + 1}  Owner: {ReadAccounts[i].Owner}   Balance: {ReadAccounts[i].Balance}");
        }

        string? selectedInput = Console.ReadLine();
        if(string.IsNullOrWhiteSpace(selectedInput) || !int.TryParse(selectedInput, out int selectedAccount) || selectedAccount < 1 || selectedAccount > ReadAccounts.Count)
        {
            Console.WriteLine("Invalid selection. ");
            return;
        }

        selectedAccount -= 1;

        for(int i = 0; i < ReadAccounts.Count; i++)
        {
            if(i == selectedAccount)
            {
                Console.WriteLine("Enter amount to deposit: ");
                string? inputDeposit = Console.ReadLine();

                if(string.IsNullOrWhiteSpace(inputDeposit) || !decimal.TryParse(inputDeposit, out decimal depositAmount) || depositAmount <= 0)
                {
                    Console.WriteLine("Invalid deposit amount.");
                    return;
                }

                ReadAccounts[i].Deposit(depositAmount);
                Console.WriteLine($"Deposit Successful! New balance: {ReadAccounts[i].Balance:C}");
            }
        }
    }

    public void ViewBalance()
    {
        Console.WriteLine("Enter the account to view balance: (Menu number)");

        for(int i = 0; i < ReadAccounts.Count; i++)
        {
            Console.WriteLine($"{i + 1}   Owner: {ReadAccounts[i].Owner}");
        }

        string? selectedIndex = Console.ReadLine();

        if(string.IsNullOrWhiteSpace(selectedIndex) || !int.TryParse(selectedIndex, out int accountIndex) || accountIndex <= 0 || accountIndex > ReadAccounts.Count)
        {
            Console.WriteLine("Invalid selection.");
            return;
        }

        accountIndex -= 1;

        for(int i = 0; i < ReadAccounts.Count; i++)
        {
            if(i == accountIndex)
            {
                Console.WriteLine($"The account owner {ReadAccounts[i].Owner} has a balance of {ReadAccounts[i].Balance:C}");
                break;
            }
        }
    }


    public void TransferFunds()
    {
        //How much to transfer
        Console.WriteLine("How much would you like to transfer?");
        string? inputAmount = Console.ReadLine();
        if(string.IsNullOrWhiteSpace(inputAmount) || !decimal.TryParse(inputAmount, out decimal transferAmount) || transferAmount <= 0)
        {
            Console.WriteLine("Invalid transfer amount.");
            return;
        }

        //Display all accounts
        Console.WriteLine("Here are all the accounts in the system:");
        for(int i = 0; i < ReadAccounts.Count; i++)
        {
            Console.WriteLine($"{i+1}  Owner: {ReadAccounts[i].Owner}  Balance: {ReadAccounts[i].Balance}");
        }

        //Account to transfer from
        Console.WriteLine("Choose the account to transfer from: (Menu number)");
        string? fromInput = Console.ReadLine();
        if(string.IsNullOrWhiteSpace(fromInput) || !int.TryParse(fromInput, out int fromIndex) || fromIndex < 1 || fromIndex > ReadAccounts.Count)
        {
            Console.WriteLine("Invalid selection.");
            return;
        }
        
        fromIndex -= 1;
        if(ReadAccounts[fromIndex].Balance < transferAmount)
        {
            Console.WriteLine("Insufficient funds for this transfer.");
            return;
        }
        ReadAccounts[fromIndex].Withdraw(transferAmount);

        //Account to transfer to
        Console.WriteLine("Choose the account to transfer to: (Menu number)");
        string? toInput = Console.ReadLine();
        if(string.IsNullOrWhiteSpace(toInput) || !int.TryParse(toInput, out int toIndex) || toIndex < 0 || toIndex > ReadAccounts.Count)
        {
            Console.WriteLine("Invalid selection.");
            return;
        }   
        toIndex -= 1;

        ReadAccounts[toIndex].Deposit(transferAmount);
        Console.WriteLine($"Transfer of {transferAmount:C} from {ReadAccounts[fromIndex].Owner} to {ReadAccounts[toIndex].Owner} completed successfully.");
    }

}
