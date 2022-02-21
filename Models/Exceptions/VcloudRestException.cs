using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WOPS_API.Models.Exceptions
{


    [Serializable]
    public class VcloudRestException : Exception
    {
        public string StatusCode { get; set; }
        public string ResponseMessage { get; set; }
        public string Endpoint { get; set; }

        public VcloudRestException(string statusCode, string responseMessage, string endpoint) : this(endpoint)
        {
            ResponseMessage = responseMessage;
            StatusCode = statusCode;
            Endpoint = endpoint;
        }

        public VcloudRestException(string message)
            : base(message)
        { }

        public VcloudRestException(string statusCode, string responseMessage, string endpoint, Exception innerException)
            : base(endpoint, innerException)
        {
            ResponseMessage = responseMessage;
            StatusCode = statusCode;
            Endpoint = endpoint;
        }
    }
}
