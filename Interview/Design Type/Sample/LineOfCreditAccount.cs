using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interview.OOP.Sample
{
    class LineOfCreditAccount: BankAccount
    {

        public LineOfCreditAccount(string name, decimal initialBalance) : base(name, initialBalance)
        {
        }

        // public LineOfCreditAccount() { }
        public override void PerformMonthEndTransactions()
        {
            var currBalance = GetBalance();
            if (currBalance < 0)
            {
                // Negate the balance to get a positive interest charge:
                decimal interest = currBalance * 0.07m;
                MakeWithdrawal(interest, DateTime.Now, "Charge monthly interest from Credit");
            }
        }

        
    }
}
