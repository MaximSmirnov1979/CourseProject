using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalFinanceAccounting
{
    public class Profit
    {
        bool monthly { get; }
        private double value { get; set; }//сумма
        public double Value { get { return value; } set { this.value = value; } }

        private DateTime date { get; set; }//дата
        private string сategory { get; set; }//категория доходов
        //конструкторы
        public Profit(double value, DateTime date, string сategory, bool monthly)
        {
            this.value = value;
            this.date = date;
            this.сategory = сategory;
            this.monthly = monthly;
        }
        public Profit() { }





    }
}
