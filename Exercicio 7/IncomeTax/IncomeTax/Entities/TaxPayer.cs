using System;
using System.Collections.Generic;
using System.Text;

namespace IncomeTax.Entities
{
    public abstract class TaxPayer
    {
        public string Name { get; set; }
        public double AnualIncame { get; set; }

        protected TaxPayer()
        {
        }

        protected TaxPayer(string name, double anualIncame)
        {
            Name = name;
            AnualIncame = anualIncame;
        }

        public abstract double TotalTax();
    }
}
