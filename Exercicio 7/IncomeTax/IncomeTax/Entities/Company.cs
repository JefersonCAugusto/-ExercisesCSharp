using System;
using System.Collections.Generic;
using System.Text;


namespace IncomeTax.Entities
{
    class Company  : TaxPayer
    {
        public int NumbersOfEmpoyees { get; set; }

        public Company(int numbersOfEmpoyees, string name, double anualIncame):base(name,anualIncame)
        {
            NumbersOfEmpoyees = numbersOfEmpoyees;
        }

        public override double TotalTax()
        {
            if (NumbersOfEmpoyees <= 10)
                return AnualIncame * 0.16;
            else
                return AnualIncame * 0.14;
        }
    }
}
