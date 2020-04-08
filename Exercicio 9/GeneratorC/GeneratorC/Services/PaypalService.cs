using System;
using System.Collections.Generic;
using System.Text;
using GeneratorC.Entities;

namespace GeneratorC.Services
{
    class PaypalService : IOnlinePaymentoService
    {


        public double Paymentfee(double amaunt)
        {
            return amaunt * 0.01;
        }

        public double Interest(double amaunt, int month)
        {
            return amaunt * 0.02 * month;
        }

    }
}
