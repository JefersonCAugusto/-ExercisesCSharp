using System;
using System.Collections.Generic;
using System.Text;

namespace GeneratorC.Entities
{
    class Contractt
    {

        public int Number { get; set; }
        public DateTime Date { get;  set; }
        public double Value { get; set; }
        public List<Installment> Installment { get; set; } = new List<Installment>();

        public Contractt(int number, DateTime date, double value)
        {
            Number = number;
            Date = date;
            Value = value;
        }
    }
}
