using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OOPExample.Models
{
    public class CheckingAccount : BankAccount
    {
        public CheckingAccount(int accountNumber, decimal balance)
        {
            AccountNumber = accountNumber;
            this.balance = balance;
        }

        public override void Deposit(decimal value)
        {
            balance += value;
        }
    }
}