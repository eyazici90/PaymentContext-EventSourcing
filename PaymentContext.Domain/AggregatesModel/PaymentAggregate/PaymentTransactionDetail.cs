﻿using System;
using System.Collections.Generic;
using System.Text;

namespace PaymentContext.Domain.AggregatesModel.PaymentAggregate
{
    public static class PaymentTransactionDetail
    {
        public static PaymentTransactionDetailState Create(Guid paymentTransactionStateId, string description)
        {
            var state = new PaymentTransactionDetailState(paymentTransactionStateId, description); 
            return state;
        }
    }
}
