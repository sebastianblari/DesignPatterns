﻿using System;

namespace ChainOfResponsabilityPattern
{
    public class ExpenseReport : IExpenseReport
    {
        public ExpenseReport(Decimal total)
        {
            Total = total;
        }

        public decimal Total 
        { 
            get;
            private set;
        }
    }
}