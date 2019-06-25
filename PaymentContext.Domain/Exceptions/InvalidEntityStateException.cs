using System;
using System.Collections.Generic;
using System.Text;

namespace PaymentContext.Domain.Exceptions
{ 
    public class InvalidEntityStateException : Exception
    {
        public InvalidEntityStateException(object entity, string messsage)
            : base(
                $"Entity {entity.GetType().Name} state change rejected {messsage}"
            )
        {
        }
    }

}
