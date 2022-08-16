using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interview.OOP.Sample
{
    public class BankAccount
    {
        private decimal Balance;
        //{
        //    get 
        //    { 
        //        decimal balance = 0;
        //        foreach (var item in allTransaction)
        //        {
        //            balance += item.Amount;
        //        }

        //        return balance;
        //    }
        //}

        public string Owner { get; set; }
        public string Number { get; }

        private static int AccountNumberSeed = 1234567890;

        private List<Transactions> allTransaction = new List<Transactions>();

        

        public BankAccount(string owner, decimal initialBalance)
        {
            Number = AccountNumberSeed.ToString();
            AccountNumberSeed++;
            // Balance = initialbalance;
            // if (initialBalance > 0)
            
            this.MakeDeposit(initialBalance, DateTime.Now, "This is Initial Balance of a Bank Account");

            Owner = owner;
        }

        public decimal GetBalance()
        {
            return Balance;
        }

        public void MakeDeposit(decimal amount, DateTime date, string note)
        {
            if (amount <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(amount), "Amount of deposit must be positive");
            }
            
            var depositTransaction = new Transactions(amount, date, note);
            allTransaction.Add(depositTransaction);
            Balance += amount;
        }


        public void MakeWithdrawal(decimal amount, DateTime date, string note)
        {
            if (amount <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(amount), "Amount of withdrawal must be positive");
            }

            Balance -= amount;
            if (Balance < 0)
            {
                throw new InvalidOperationException("Not sufficient funds for this withdrawal");
            }

            var withdrawalTransaction = new Transactions(-amount, date, note);
            allTransaction.Add(withdrawalTransaction);
        }

        public string GetAccountHistory()
        {
            var report = new StringBuilder();

            decimal balance = 0;
            report.AppendLine("Date\t\tAmount\tBalance\tNote");
            foreach (var item in allTransaction)
            {
                balance += item.Amount;
                report.AppendLine($"{item.Date.ToShortDateString()}\t{item.Amount}\t{balance}\t{item.Notes}");
            }

            return report.ToString();
        }

        public virtual void PerformMonthEndTransactions() { }


    }
}
