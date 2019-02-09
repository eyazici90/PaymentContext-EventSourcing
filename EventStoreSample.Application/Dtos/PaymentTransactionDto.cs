using System;
using System.Collections.Generic;
using System.Text;

namespace EventStoreSample.Application.Dtos
{
    public class PaymentTransactionDto
    {
        public Guid  Id { get; set; }

        public string Msisdn { get;  set; }

        public string Description { get;  set; }

        public string OrderId { get;  set; }

        public string ResponseCode { get;  set; }

        public string ResponseMessage { get;  set; }

        public int TransactionStatusId { get;  set; }

        public int TransactionTypeId { get;  set; }

        public int? ReferanceTransactionId { get;  set; }
    }
}
