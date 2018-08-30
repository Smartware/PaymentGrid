using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace PaymentGateway.Domain.Payload.Quickteller
{
    public class NameEnquiry : QuicktellerBaseServiceResponse
    {
        [JsonProperty("accountName")]
        public string AccountName { get; set; }
    }
}
