using PaymentContext.Domain.AggregatesModel.PaymentAggregate;
using System;
using System.Collections.Generic;
using System.Text;

namespace PaymentContext.IntegrationEvents
{

    public class TransactionCreatedIntegrationEvent
    {
        public DateTime TransactionDateTime { get; private set; }

        public string Msisdn { get; private set; }

        public string OrderId { get; private set; }

        public TransactionCreatedIntegrationEvent(DateTime transactionDateTime, string msiSdn, string orderId)
        {
            this.TransactionDateTime = transactionDateTime;
            this.Msisdn = msiSdn;
            this.OrderId = orderId;
        }
    }
}
