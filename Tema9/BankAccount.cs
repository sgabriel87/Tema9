using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tema9
{
    public class BankAccount
    {
        public Guid Id { get; private set; }
        protected string AccountType { get; private set; }
        protected string OwnerName { get; private set; }
        protected decimal Balance { get; set; }

        public BankAccount(string ownerName, string accountType)
        {
            Id = Guid.NewGuid();
            OwnerName = ownerName;
            AccountType = accountType;
            Balance = 0;
        }
        /// <summary>
        /// Displays Balance of the account
        /// </summary>
        public virtual void SeeBalance()
        {
            Console.WriteLine($"Account Type: {AccountType}, Owner Name: {OwnerName}, Balance: {Balance}\n");
        }
        /// <summary>
        /// Add money to the account
        /// </summary>
        /// <param name="amount"></param>
        public virtual void AddMoney(decimal amount)
        {
            Balance += amount;
            Console.WriteLine($"Added {amount} to {OwnerName}'s {AccountType} account.");
        }
        /// <summary>
        /// Get money from the account
        /// </summary>
        /// <param name="amount"></param>
        public virtual void GetMoney(decimal amount)
        {
            if (Balance >= amount)
            {
                Balance -= amount;
                Console.WriteLine($"Withdrawn {amount} from {OwnerName}'s {AccountType} account.");
            }
            else
            {
                Console.WriteLine($"Insufficient funds in {OwnerName}'s {AccountType} account.");
            }
        }
    }
}
