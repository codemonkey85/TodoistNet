using System;

namespace TodoistNetTest.Objects
{
    public class TaskComment
    {
        public TaskComment()
        {
            Content = string.Empty;
            DateUtc = null;
        }

        public string Content { get; set; }
        public DateTime? DateUtc { get; set; }

        public DateTime? DateLocal
        {
            get
            {
                if (DateUtc == null)
                {
                    return null;
                }
                return DateUtc.Value.ToLocalTime();
            }
        }
    }
}