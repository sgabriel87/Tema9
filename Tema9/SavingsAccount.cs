using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tema9
{
    public class SavingsAccount : BankAccount
    {
        private decimal interestRate;

        public SavingsAccount(string ownerName, decimal interestRate) : base(ownerName, "Savings Account")
        {
            this.interestRate = interestRate;
        }

        public override void AddMoney(decimal amount)
        {
            Balance += amount * (1 + interestRate);
            Console.WriteLine($"Added {amount} to {OwnerName}'s Savings Account with interest rate {interestRate}.");
        }
    }
}
