using System;
using System.Collections.Generic;
using System.Text;

namespace Products.Entities
{
    class ImportedProduct : Product
    {
        public double CustomsFee { get; set; }

        public ImportedProduct(double customsFee, string name, double price) : base(name, price)
        {
            CustomsFee = customsFee;
        }

        public double TotalPrice()
        {
            return Price + CustomsFee;

        }
        public override string PriceTag()
        {
               
            return $"Name: {Name} ${TotalPrice()}";

        }
    }
}
