﻿using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace PaymentContext.Domain.AggregatesModel.PaymentAggregate
{
    public static class Events
    {
        public static class V1
        {
            public class TransactionAmountChangedDomainEvent : INotification
            {
                public decimal Amount { get; private set; }

                public TransactionAmountChangedDomainEvent(decimal amount)
                {
                    this.Amount = amount;
                }
            }

            public class TransactionCreatedDomainEvent : INotification
            {
                public DateTime TransactionDateTime { get; private set; }

                public string Msisdn { get; private set; }

                public string OrderId { get; private set; }

                public TransactionCreatedDomainEvent(string msisdn, string orderId, DateTime transactionDateTime)
                {
                    this.Msisdn = msisdn;
                    this.OrderId = orderId;
                    this.TransactionDateTime = transactionDateTime;
                }
            }

            public class TransactionStatusChangedDomainEvent: INotification
            {
                public int TransactionStatusId { get; private set; }

                public TransactionStatusChangedDomainEvent(int transactionStatusId)
                {
                    this.TransactionStatusId = transactionStatusId;
                }
            }

        }
    }
}