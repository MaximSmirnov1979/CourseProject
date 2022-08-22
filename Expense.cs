using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalFinanceAccounting
{
    public class Expense
    {
        bool monthly { get; }
        private double value { get; set; }
        public double Value { get { return value; } set { this.value = value; } }
        private DateTime Date { get; set; }
        private string Category { get; set; }

        public Expense(double value, DateTime date, string сategory, bool monthly)
        {
            this.value = value;
            this.Date = date;
            this.Category = сategory;
            this.monthly = monthly;
        }
        public Expense() { }
    }
}
