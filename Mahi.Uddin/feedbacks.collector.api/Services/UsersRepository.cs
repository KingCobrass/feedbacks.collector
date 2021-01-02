using Feedbacks.CollectorInterface.Response;
using Feedbacks.CollectorInterface.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Feedbacks.Collector.API.Services
{
    public class UsersRepository : IUsersRepository
    {
        public async Task<IFCResponse> AddUser(IUser user)
        {
            throw new NotImplementedException();
        }

        public async Task<IFCResponse> DeleteUser(string userId)
        {
            throw new NotImplementedException();
        }

        public async Task<IFCRootResponse<IFCResponse>> GetUser(string userId)
        {
            throw new NotImplementedException();
        }

        public async Task<IFCRootResponse<IFCResponse>> GetUsers()
        {
            throw new NotImplementedException();
        }

        public async Task<IFCResponse> UpdateUser(string userId,IUser user)
        {
            throw new NotImplementedException();
        }
    }
}
