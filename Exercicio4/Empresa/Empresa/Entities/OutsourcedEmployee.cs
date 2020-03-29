using System;
using System.Collections.Generic;
using System.Text;

namespace Empresa.Entities
{
    class OutsourcedEmployee : Employee
    {
        public double AdditionalCharge { get; set; }
        public override double Payment()
        {
            return base.Payment() + (AdditionalCharge * 1.1);
        }


    }
}