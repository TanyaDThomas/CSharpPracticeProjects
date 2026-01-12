using System;

namespace SimpleBankingSystem;

public class BankAccount
{
    public string Owner { get; }
    public decimal Balance { get; private set;}

    public BankAccount(string owner, decimal balance)
    {
        Owner = owner;
        Balance = balance;
    }

    public void Deposit(decimal amount)
    {
        if(amount <= 0)
        {
            Console.WriteLine("Deposit amount must be positive.");
            return;
        }

        Balance += amount;
    }

    public void Withdraw(decimal amount)
    {
        if(amount > Balance)
        {
            Console.WriteLine("Insufficient funds for this withdrawal.");
            return;
        }

        Balance -= amount;
         
    }
}
