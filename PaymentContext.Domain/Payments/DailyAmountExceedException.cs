using System;
using System.Collections.Generic;
using System.Text;

namespace PaymentContext.Domain.Exceptions
{ 
    public class DailyAmountExceedException : Exception
    {

        public DailyAmountExceedException(string id)
            : base($"Max daily amount exceed for this transaction {id}")
        { }
 
    }
}
