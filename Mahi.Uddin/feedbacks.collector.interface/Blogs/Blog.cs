using System;
using System.Collections.Generic;
using System.Text;

namespace Feedbacks.CollectorInterface.Blogs
{
    public class Blog : IBlog
    {
        public string Id { get; set; }
        public string Title { get; set; }
        public string Types { get; set; }
        public string Tags { get; set; }
        public string BlogsDetails { get; set; }
        public string BlogsById { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime ModifyDate { get; set; }
        public string IsActive { get; set; }
    }
}
