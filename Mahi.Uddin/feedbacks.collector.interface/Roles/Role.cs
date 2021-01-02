using System;
using System.Collections.Generic;
using System.Text;

namespace Feedbacks.CollectorInterface.Roles
{
    public class Role : IRole
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string RoleId { get; set; }
        public string Description { get; set; }
        public int IsActive { get; set; }
    }
}
