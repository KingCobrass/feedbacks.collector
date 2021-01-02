using System;
using System.Collections.Generic;
using System.Text;

namespace Feedbacks.CollectorInterface.DatabaseRepository
{
    public interface IDatabaseConnectionParams
    {
        string GetConnectionString();
        string GetProvider();
    }
}
