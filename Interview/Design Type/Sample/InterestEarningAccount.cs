using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interview.OOP.Sample
{
    class InterestEarningAccount: BankAccount
    {
        public InterestEarningAccount(string name, decimal initialBalance) : base(name, initialBalance)
        {
        }

        public override void PerformMonthEndTransactions()
        {
            var currBalance = GetBalance();
            if (currBalance > 500m)
            {
                decimal interest = currBalance * 0.05m;
                MakeDeposit(interest, DateTime.Now, "deposit monthly interest");
            }
        }

    }
}
