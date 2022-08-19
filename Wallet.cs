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
        private List<Expenses> expenses; //Расходы
        private List<Profit> profit; //Доходы
        public Wallet(string currency, List<Expenses> exp, List<Profit> prof, double value = 0)
        {
            this.Currency = currency;
            this.expenses = exp;
            this.profit = prof;
            this.Value = value;
        }
        
    }
}
