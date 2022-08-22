using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalFinanceAccounting
{
    public class Wallet
    {
        private string currency;//Валюта
        public string Currency { get { return currency; } }
        private double value { get; set; } //Кол-во денег на счету
        public double Value { get { return value; } set { this.value = value;} }
        private List<Expense> expenses; //Расходы
        private List<Profit> profits; //Доходы
        public Wallet(string currency, List<Expense> exp = null, List<Profit> prof = null, double value = 0)
        {
            this.currency = currency;
            this.expenses = exp;
            this.profits = prof;
            this.value = value;
        }
        void AddProfit(double value, DateTime date, string сategory, bool monthly = false)
        {
            this.profits.Append(new Profit(value, date, сategory, monthly));
        }//Добавление в список нового дохода
        void AddExpence(double value, DateTime date, string сategory, bool monthly = false)
        {
            this.expenses.Append(new Expense(value, date, сategory, monthly));
        }//Добавление в список нового расхода
        void Calculate()
        {
        }

    }
}
