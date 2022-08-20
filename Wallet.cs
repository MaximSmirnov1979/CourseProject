using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalFinanceAccounting
{
    public class Wallet
    {
        private string Currency { get;} //Валюта
        private double Value { get; set; } //Кол-во денег на счету
        private List<Expense> expenses; //Расходы
        private List<Profit> profits; //Доходы
        public Wallet(string currency, List<Expense> exp = null, List<Profit> prof = null, double value = 0)
        {
            this.Currency = currency;
            this.expenses = exp;
            this.profits = prof;
            this.Value = value;
        }
        void AddProfit(double value, DateTime date, string сategory)
        {
            this.profits.Append(new Profit(value, date, сategory));
        }
        void AddExpence(double value, DateTime date, string сategory)
        {
            this.expenses.Append(new Expense(value, date, сategory));
        }
        
    }
}
