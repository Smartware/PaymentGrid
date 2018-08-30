﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace PaymentGateway.Domain.Payload.Quickteller
{
    public class QuicktellerCustomerViewModel
    {
        public bool IsSuccessful { get; set; }
        public String TerminalId { get; set; }
        public String ResponseCode { get; set; }
        public String ResponseDescription { get; set; }
        public String FullName { get; set; }
        [JsonProperty("paymentCode")]
        public String PaymentCode { get; set; }
        [JsonProperty("customerId")]
        public String CustomerId { get; set; }
    }

}
