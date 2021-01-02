using Feedbacks.CollectorInterface.Operation;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Feedbacks.CollectorInterface.DatabaseRepository
{
    public interface IClientDatabaseRepository : IOperation
    {
        Task<int> GetBlogPostCountAsync();
    }
}
