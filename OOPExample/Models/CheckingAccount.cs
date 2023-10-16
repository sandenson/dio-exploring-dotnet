using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OOPExample.Models
{
    public class CheckingAccount
    {
        public CheckingAccount(int accountNumber, decimal balance)
        {
            AccountNumber = accountNumber;
            this.balance = balance;
        }

        public int AccountNumber { get; set; }
        private decimal balance;

        public void Withdraw(decimal value)
        {
            if (balance >= value)
            {
                balance -= value;
                Console.WriteLine("Withdrawal successful.");
            }
            else
            {
                Console.WriteLine("Not enough balance.");
            }
        }

        public void DisplayBalance()
        {
            Console.WriteLine($"Your current balance: {balance}");
        }
    }
}