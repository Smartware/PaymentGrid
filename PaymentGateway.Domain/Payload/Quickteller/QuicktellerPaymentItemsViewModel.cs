using Newtonsoft.Json;
using PaymentGateway.Domain.Payload.Quickteller;
using System;
using System.Collections.Generic;
using System.Text;

namespace PaymentGateway.Domain.Payload.Quickteller
{
    public class QuicktellerPaymentItemsViewModel : QuicktellerBaseServiceResponse
    {
        public string ResponseCode { get; set; }
        public string ResponseDescription { get; set; }
        [JsonProperty("paymentitems")]
        public List<QuicktellerPaymentItem> PaymentItems { get; set; }
    }
}
