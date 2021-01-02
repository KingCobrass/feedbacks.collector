using Feedbacks.CollectorInterface.Response;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Feedbacks.CollectorInterface.Users
{
    public interface IUsersRepository
    {
        Task<IFCResponse> AddUser(IUser user);
        Task<IFCResponse> UpdateUser(string userId,IUser user);
        Task<IFCResponse> DeleteUser(string userId);
        Task<IFCRootResponse<IFCResponse>> GetUser(string userId);
        Task<IFCRootResponse<IFCResponse>> GetUsers();
    }
}
