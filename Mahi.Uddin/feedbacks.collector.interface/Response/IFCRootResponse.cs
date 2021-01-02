using System;
using System.Collections.Generic;
using System.Text;

namespace Feedbacks.CollectorInterface.Response
{
    public interface IFCRootResponse<T>: IFCResponse
    {
        T ResponseData { get; set; }
    }
}
