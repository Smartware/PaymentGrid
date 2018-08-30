using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace PaymentGateway.Domain.Payload
{
    [DataContract]
    public class ServiceError
    {
        [DataMember]
        [JsonProperty("code")]
        public String Code { get; set; }
        [DataMember]
        [JsonProperty("message")]
        public String Message { get; set; }
    }
}
