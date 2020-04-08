using System;
using System.Collections.Generic;
using System.Text;

namespace GeneratorC.Entities
{
    class Contract
    {

        public int Number { get; set; }
        public DateTime Date { get; private set; }
        public double TotalValue { get; set; }
        public Installment Installment { get; set; }


        public Contract(int number, DateTime date)
        {
            Number = number;
            Date = date;
        }


    }
}
