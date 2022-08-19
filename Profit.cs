using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalFinanceAccounting
{
    public class Profit
    {
        private double value { get; set; }//сумма
        private DateTime date { get; set; }//дата
        private string сategory { get; set; }//категория доходов
        //конструкторы
        public Profit(double value, DateTime date, string сategory)
        {
            this.value = value;
            this.date = date;
            this.сategory = сategory;
        }
        public Profit() { }





    }
}
