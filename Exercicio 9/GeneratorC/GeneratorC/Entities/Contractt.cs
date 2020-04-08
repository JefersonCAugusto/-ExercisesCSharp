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

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("Nº: ");
            sb.AppendLine(Number.ToString());
            sb.AppendLine("-------------");
            foreach (Installment x1 in Installment)
            {
                sb.Append("Valor: ");
                sb.AppendLine(x1.Amount.ToString());
                sb.Append("Vencimento: ");
                sb.AppendLine(x1.DueDate.ToString());
                sb.AppendLine("-------------");
                
            }
            return sb.ToString();

        }
    }
}
