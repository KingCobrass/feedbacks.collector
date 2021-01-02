using System;
using System.Collections.Generic;
using System.Text;

namespace Feedbacks.CollectorInterface.Response
{
    public class FCResponse : IFCResponse
    {
        public string Status { get; set; }
        public string Message { get; set; }
        public string ResponseCode { get; set; }
    }
}
