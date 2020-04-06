using System;
using System.Collections.Generic;
using System.Text;
using GeneratorC.Entities;

namespace GeneratorC.Services
{
    class Interest
    {
        public double SimpleJ { get; set; }     //juros simples
        public double FixedT { get; set; }      //taxa fixa

        public Interest()
        {
            SimpleJ = 0.01;
            FixedT = 0.02;
        }

        double calculator(Contract contract)
        {
            double v1 = contract.TotalValue;
            double result = v1 + (v1 * SimpleJ) + (v1 * FixedT);
            return result;
        }
    }
}
