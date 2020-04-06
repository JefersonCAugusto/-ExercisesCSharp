using System;
using System.Collections.Generic;
using System.Text;

namespace GeneratorC.Entities
{
    class Installment           //prestações
    {
        public DateTime Date { get; set; }
        public double Amount { get; set; }
        public int Quantity { get; private set; }

        public Installment(DateTime date, double amount)
        {
            Date = date;
            Amount = amount;

        }
    }
}
