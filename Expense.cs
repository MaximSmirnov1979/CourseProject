﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalFinanceAccounting
{
    public class Expense
    {
        private double value { get; set; }
        private DateTime date { get; set; }
        private string сategory { get; set; }

        public Expense(double value, DateTime date, string сategory)
        {
            this.value = value;
            this.date = date;
            this.сategory = сategory;
        }
        public Expense() { }
    }
}