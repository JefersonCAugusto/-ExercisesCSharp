using System;
using System.Collections.Generic;
using System.Text;

namespace Products.Entities
{
    class UsedProduct : Product
    {
        public DateTime ManufactureDate { get; set; }

        public UsedProduct(DateTime manufactureDate, string name, double price) : base(name, price)
        {
            ManufactureDate = manufactureDate;
        }

        public override string PriceTag()
        {
            return $"Item: {Name} (Used) ${Price} ({ManufactureDate.ToString("dd/MM/YYYY")})";
        }

    }
}
