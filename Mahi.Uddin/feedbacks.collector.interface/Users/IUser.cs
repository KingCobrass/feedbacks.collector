using System;
using System.Collections.Generic;
using System.Text;

namespace Feedbacks.CollectorInterface.Users
{
    public interface IUser
    {
        string Id { get; set; }
        string Name { get; set; }
        string UserName { get; set; }
        string Address { get; set; }
        string MobileNumber { get; set; }
        string Email { get; set; }
        string Password { get; set; }
        string RoleId { get; set; }
        DateTime CreateDate { get; set; }
        DateTime? ModifyDate { get; set; }
        bool IsActive { get; set; }

    }
}
