﻿using PaymentContext.IntegrationEvents;
using MassTransit;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace PaymentContext.TelemetryListener.Consumers
{
    public class TransactionCreatedConsumer :  IConsumer<TransactionCreatedIntegrationEvent>
    {
        public async Task Consume(ConsumeContext<TransactionCreatedIntegrationEvent> context)
        {
            var message = context.Message;
            //Manage QueryStorage here !!!
         }
    }
}
