using System;
using System.Collections.Generic;
using System.Text;

namespace GeneratorC.Entities
{
    class Installment           //prestações
    {
        public DateTime DueDate { get; set; }
        public double Amount { get; set; }
      

        public Installment(DateTime dueDate, double amount)
        {
            DueDate = dueDate;
            Amount = amount;

        }
    }
}
