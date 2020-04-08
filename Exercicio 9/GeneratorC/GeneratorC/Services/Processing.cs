using System;
using System.Collections.Generic;
using System.Text;
using GeneratorC.Entities;

namespace GeneratorC.Services
{
    class Processing
    {
        public IOnlinePaymentoService _onlinePaymentoService { get; set; }

        public Processing(IOnlinePaymentoService onlinePaymentoService)
        {
            _onlinePaymentoService = onlinePaymentoService;
        }

        public void ProcessContract(Contractt contractt, double months)

        {
            double value = contractt.Value/months;
            value = _onlinePaymentoService.Paymentfee(value);
            DateTime t1 = contractt.Date;
            for (int i = 1; i <= months; i++)

                contractt.Installment.Add(new Installment(t1.AddMonths(i), _onlinePaymentoService.Interest(value, i)));


        }




    }
}
