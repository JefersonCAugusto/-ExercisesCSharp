using System;
using System.Collections.Generic;
using System.Text;

namespace GeneratorC.Entities
{
    class Contract
    {

        public int Name { get; set; }
        public DateTime Date { get; private set; }
        public double TotalValue { get; set; }
        public Installment Installment { get; set; }


        public Contract(int name, DateTime date)
        {
            Name = name;
            Date = date;
        }
    }
}
