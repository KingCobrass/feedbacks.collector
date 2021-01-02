using System;
using System.Collections.Generic;
using System.Text;

namespace Feedbacks.CollectorInterface.Blogs
{
    public interface IBlog
    {
        string Id { get; set; }
        string Title { get; set; }
        string Types { get; set; }
        string Tags { get; set; }
        string BlogsDetails { get; set; }
        string BlogsById { get; set; }
        DateTime CreateDate { get; set; }
        DateTime ModifyDate { get; set; }
        string IsActive { get; set; }

    }
}
