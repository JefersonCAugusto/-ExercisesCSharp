using System;
using System.Collections.Generic;
using System.Text;
using GeneratorC.Entities;
namespace GeneratorC.Services
{
    interface IOnlinePaymentoService
    {
        public double Paymentfee(double amaunt);
        public double Interest(double amaunt, int month);


    }
}
