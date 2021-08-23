using System;
using System.Collections.Generic;
using System.Text;

namespace Trat.Exceção.Exceptions
{
    class DomainException : ApplicationException
    {

        public DomainException(string message) : base(message)
        {

        }
    }
}
