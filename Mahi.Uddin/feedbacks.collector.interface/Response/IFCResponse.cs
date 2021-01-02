using System;
using System.Collections.Generic;
using System.Text;

namespace Feedbacks.CollectorInterface.Response
{
    public interface IFCResponse
    {
        string Status { get; set; }
        string Message { get; set; }
        string ResponseCode { get; set; }
    }
}
