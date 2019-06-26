﻿using Galaxy.Domain;
using PaymentContext.Domain.Exceptions;
using System;
using System.Collections.Generic;
using System.Text;

namespace PaymentContext.Domain.AggregatesModel.PaymentAggregate
{
    public class PaymentTransactionDetailState : EntityState
    {
        public Guid _paymentTransactionStateId { get; private set; }
        public string _description { get; private set; }

        public bool _isNotified { get; private set; }
        private PaymentTransactionDetailState()
        {
            RegisterEvent<Events.V1.TransactionDetailCreatedDomainEvent>(When);
        }

        public PaymentTransactionDetailState(Guid paymentTransactionStateId, string description, bool isNotified = false) : this() =>
                   EnsureValidState(paymentTransactionStateId, description);


        public bool EnsureValidState(Guid paymentTransactionStateId, string description)
        {

            if (paymentTransactionStateId == default) { throw new InvalidEntityStateException(this, $"Invalid paymentTransactionStateId"); }

            if (string.IsNullOrWhiteSpace(description)) { throw new InvalidEntityStateException(this, $"Invalid description"); }

            return true;
        }

        private void When(Events.V1.TransactionDetailCreatedDomainEvent @event)
        {
            this._description = @event.Description;
            this._paymentTransactionStateId = @event.PaymentTransactionId;
        }

    }
}
