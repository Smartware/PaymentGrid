using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace PaymentGateway.Domain.Payload.Quickteller
{
    public class CustomerValidationModel
    {

        [JsonProperty("customers")]
        public List<QuicktellerCustomerViewModel> customers { get; set; }

    }
}
