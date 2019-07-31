using System;
using System.Collections.Generic;
using System.Text;

namespace PaymentContext.Domain.Exceptions
{
    public class PaymentDomainException : Exception
    {
        public PaymentDomainException()
        { }

        public PaymentDomainException(string message)
            : base(message)
        { }

        public PaymentDomainException(string message, Exception innerException)
            : base(message, innerException)
        { }
    }
}
