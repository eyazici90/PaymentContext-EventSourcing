using System;
using System.Collections.Generic;
using System.Text;

namespace PaymentContext.Domain.Extensions
{
    public static class StateFactory
    {
        public static T Create<T>(Func<T> factory, Action<T> appliers)
        {
            var obj = factory();
            appliers(obj);
            return obj;
        }
    }
}
