using System;
using System.Collections.Generic;
using System.Text;

namespace Feedbacks.CollectorInterface.Users
{
    public class User : IUser
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string MobileNumber { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime? ModifyDate { get; set; }
        public bool IsActive { get; set; }
        public string UserName { get; set; }
        public string RoleId { get; set; }
    }
}
