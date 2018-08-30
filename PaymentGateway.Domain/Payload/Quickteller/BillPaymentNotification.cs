using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace PaymentGateway.Domain.Payload.Quickteller
{
    public class BillPaymentNotification
    {
        [JsonProperty("terminalId")]
        public String TerminalId { get; set; }
        [JsonProperty("paymentCode")]
        public String PaymentCode { get; set; }
        [JsonProperty("customerId")]
        public String CustomerId { get; set; }
        [JsonProperty("customerMobile")]
        public String CustomerMobile { get; set; }
        [JsonProperty("customerEmail")]
        public String CustomerEmail { get; set; }
        [JsonProperty("amount")]
        public String Amount { get; set; }
        [JsonProperty("requestReference")]
        public String RequestReference { get; set; }
    }
}
