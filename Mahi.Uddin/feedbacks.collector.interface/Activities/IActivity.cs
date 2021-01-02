using System;
using System.Collections.Generic;
using System.Text;

namespace Feedbacks.CollectorInterface.Activities
{
    public interface IActivity
    {
        string Id { get; set; }
        string ActivityById { get; set; }
        string BlogsRefId { get; set; }
        string Type { get; set; }
        string Comments { get; set; }
        string FeelingsTypes { get; set; }
        int LikeCount { get; set; }
        int DisLikeCount { get; set; }
        DateTime CreateDate { get; set; }
        DateTime ModifyDate { get; set; }

    }
}
