using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class ATM
{
    static void Main()
    {
        decimal balance = 1000.00m;
        int pin = 1234;
        int attempts = 0;
        const int maxAttempts = 3;

        // PIN validation
        while (attempts < maxAttempts)
        {
            Console.Write("Enter your PIN: ");
            if (int.TryParse(Console.ReadLine(), out int enteredPin) && enteredPin == pin)
            {
                ShowMenu(ref balance);
                return;
            }
            else
            {
                attempts++;
                Console.WriteLine($"Invalid PIN. {maxAttempts - attempts} attempt(s) remaining.");
            }
        }

        Console.WriteLine("Maximum attempts exceeded. Exiting.");
    }

    static void ShowMenu(ref decimal balance)
    {
        while (true)
        {
            Console.WriteLine("\nATM Menu:");
            Console.WriteLine("1. Check Balance");
            Console.WriteLine("2. Deposit Money");
            Console.WriteLine("3. Withdraw Money");
            Console.WriteLine("4. Exit");
            Console.Write("Choose an option: ");

            switch (Console.ReadLine())
            {
                case "1":
                    CheckBalance(balance);
                    break;
                case "2":
                    DepositMoney(ref balance);
                    break;
                case "3":
                    WithdrawMoney(ref balance);
                    break;
                case "4":
                    Console.WriteLine("Thank you for using the ATM. Goodbye!");
                    return;
                default:
                    Console.WriteLine("Invalid option. Please try again.");
                    break;
            }
        }
    }

    static void CheckBalance(decimal balance)
    {
        Console.WriteLine($"Your current balance is: {balance:C}");
    }

    static void DepositMoney(ref decimal balance)
    {
        Console.Write("Enter the amount to deposit: ");
        if (decimal.TryParse(Console.ReadLine(), out decimal depositAmount) && depositAmount > 0)
        {
            balance += depositAmount;
            Console.WriteLine($"Successfully deposited {depositAmount:C}. New balance: {balance:C}");
        }
        else
        {
            Console.WriteLine("Invalid amount. Please enter a positive number.");
        }
    }

    static void WithdrawMoney(ref decimal balance)
    {
        Console.Write("Enter the amount to withdraw: ");
        if (decimal.TryParse(Console.ReadLine(), out decimal withdrawAmount) && withdrawAmount > 0)
        {
            if (withdrawAmount <= balance)
            {
                balance -= withdrawAmount;
                Console.WriteLine($"Successfully withdrew {withdrawAmount:C}. New balance: {balance:C}");
            }
            else
            {
                Console.WriteLine("Insufficient funds.");
            }
        }
        else
        {
            Console.WriteLine("Invalid amount. Please enter a positive number.");
        }
    }
}