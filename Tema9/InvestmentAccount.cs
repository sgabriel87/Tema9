using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tema9
{
    public class InvestmentAccount : BankAccount
    {
        private int withdrawalDay;
        private bool isWithdrawalAllowed = false;

        public InvestmentAccount(string ownerName, int withdrawalDay) : base(ownerName, "Investment Account")
        {
            this.withdrawalDay = withdrawalDay;
        }

        public override void GetMoney(decimal amount)
        {
            if (DateTime.Now.Day >= withdrawalDay && isWithdrawalAllowed)
            {
                base.GetMoney(amount);
            }
            else
            {
                Console.WriteLine($"Withdrawal not allowed before day {withdrawalDay}.");
            }
        }

        public void AllowWithdrawal()
        {
            isWithdrawalAllowed = true;
        }
    }
}
