using System;
using System.Collections.Generic;
using System.Text;

namespace Feedbacks.CollectorInterface.Activities
{
    public class Activity : IActivity
    {
        public string Id { get; set; }
        /// <summary>
        /// User Id
        /// </summary>
        public string ActivityById { get; set; }
        /// <summary>
        /// Blog Id
        /// </summary>
        public string BlogsRefId { get; set; }
        public string Type { get; set; }
        public string Comments { get; set; }
        public string FeelingsTypes { get; set; }
        public int LikeCount { get; set; }
        public int DisLikeCount { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime ModifyDate { get; set; }
    }
}
