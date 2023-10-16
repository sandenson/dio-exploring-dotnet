namespace OOPExample.Models
{
    public abstract class BankAccount
    {
        public int AccountNumber { get; set; }
        protected decimal balance;

        public abstract void Deposit(decimal value);

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