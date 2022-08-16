using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interview.OOP.Sample
{
    public class Transactions
    {

        public decimal Amount { get; }
        public DateTime Date { get; }
        public string Notes { get; }

        
        public Transactions(decimal amount, DateTime date, string note)
        {
            Amount = amount;
            Date = date;
            Notes = note;
        }
    }
}
