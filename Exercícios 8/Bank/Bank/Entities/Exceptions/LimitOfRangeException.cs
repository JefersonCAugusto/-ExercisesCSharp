using System;
using System.Collections.Generic;
using System.Text;

namespace Bank.Entities.Exceptions
{
    class LimitOfRangeException : ApplicationException
    {

        public LimitOfRangeException(string message) : base(message)
        { 
        
        }
    }
}
