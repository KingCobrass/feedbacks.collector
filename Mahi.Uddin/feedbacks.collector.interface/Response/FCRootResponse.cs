using System;
using System.Collections.Generic;
using System.Text;

namespace Feedbacks.CollectorInterface.Response
{
    public class FCRootResponse<T> : IFCRootResponse<T>
    {
        public string Status { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string Message { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string ResponseCode { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public T ResponseData { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    }
}
