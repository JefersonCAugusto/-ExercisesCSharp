using System;
using System.Collections.Generic;
using System.Text;

namespace Bank.Entities.Exceptions
{
    class LimitException : ApplicationException
    {
        public LimitException(string message) : base(message)
        { 
        
        }
    }
}
