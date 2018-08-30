using Newtonsoft.Json;
using System.Linq;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace PaymentGateway.Domain.Payload.Quickteller
{
    public abstract class QuicktellerBaseServiceResponse
    {
        public string Code { get; set; }
        public string Message { get; set; }

        [JsonProperty("errors")]
        public List<ServiceError> Errors { get; set; } = new List<ServiceError>();

        [JsonProperty("error")]
        public ServiceError Error { get; set; } = new ServiceError();

        public bool HasErrors
        {
            get
            {
                if (Errors != null && Errors?.Count() > 0)
                {
                    return true;
                }
                else return false;
            }
        }
    }
}
