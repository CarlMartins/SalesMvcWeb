using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SalesWeb.Services.Exceptions
{
    public class DdConcurrencyException : ApplicationException
    {
        public DdConcurrencyException(string message) : base(message)
        {

        }
    }
}
