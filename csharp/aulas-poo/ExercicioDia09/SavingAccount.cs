
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
namespace ExercicioDia09
{
    public class SavingAccount : Account
    {
        public int AccountNo { get; set; }
        public double Balance { get; set; }

        public SavingAccount(int accountNo, double balance)
        {
            AccountNo = accountNo;
            Balance = balance;
        }


        public void Deposit(double amount)
        {
            if (amount <= 0)
            {
                Console.WriteLine("Deposit amount must be positive.");
                return;
            }
            Balance += amount;
            Console.WriteLine($"Deposited {amount:C}. New balance: {Balance:C}");
        }

        public void WithDraw(double amount)
        {
            if (amount <= 0)
            {
                Console.WriteLine("Withdrawal amount must be positive.");
                return;
            }

            if (Balance >= amount)
            {
                Balance -= amount;
                Console.WriteLine($"Withdrew {amount:C}. New balance: {Balance:C}");
            }
            else
            {
                Console.WriteLine("Insufficient balance.");
            }
        }

        public void ShowBalance()
        {
            Console.WriteLine($"Current balance: {Balance:C}");
        }
    }
}
