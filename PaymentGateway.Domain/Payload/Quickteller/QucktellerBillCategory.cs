using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace PaymentGateway.Domain.Payload.Quickteller
{
    public class QuicktellerBillCategory
    {
        [JsonProperty("categoryId")]
        public String CategoryId { get; set; }
        [JsonProperty("categoryName")]
        public String CategoryName { get; set; }
        [JsonProperty("categoryDescription")]
        public String CategoryDescription { get; set; }
    }
}
