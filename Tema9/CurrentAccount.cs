using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tema9
{
    public class CurrentAccount : BankAccount
    {
        private const decimal OverdraftLimit = 5000m;

        public CurrentAccount(string ownerName) : base(ownerName, "Current Account") { }

        public override void GetMoney(decimal amount)
        {
            if (Balance + OverdraftLimit >= amount)
            {
                Balance -= amount;
                Console.WriteLine($"Withdrawn {amount} from {OwnerName}'s Current Account.");
            }
            else
            {
                Console.WriteLine($"Transaction failed: Insufficient funds or exceeding overdraft limit in Current Account.");
            }
        }
    }
}
