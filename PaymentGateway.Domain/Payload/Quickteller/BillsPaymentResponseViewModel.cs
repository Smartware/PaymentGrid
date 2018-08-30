using PaymentGateway.Domain.Payload.Quickteller;
using System;
using System.Collections.Generic;
using System.Text;

namespace PaymentGateway.Domain.Payload
{
    public class BillsPaymentResponseViewModel : QuicktellerBaseServiceResponse
    {
        public String ResponseCode { get; set; }
        public String TransactionRef { get; set; }
        public String ResponseMessage { get; set; }
        public String AmountPaid { get; set; }

        public BillsPaymentResponseViewModel()
        {
        }
    }
}
