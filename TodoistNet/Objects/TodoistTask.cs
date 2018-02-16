using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;

namespace TodoistNetTest.Objects
{
    public class TodoistTask
    {
        public TodoistTask()
        {
            Content = string.Empty;
            DueDateUtc = null;
            ProjectName = string.Empty;
            Comments = new List<TaskComment>();
        }

        public string ProjectName { get; set; }
        public string Content { get; set; }
        public string DateString { get; set; }

        [Browsable(false)]
        public DateTime? DueDateUtc { get; set; }

        public DateTime? DueDateLocal
        {
            get
            {
                if (DueDateUtc == null) return null;
                return DueDateUtc.Value.ToLocalTime();
            }
        }

        public bool IsAllDay
        {
            get
            {
                if (DueDateLocal == null)
                    return false;

                return (DueDateLocal.Value.Hour == 23 && DueDateLocal.Value.Minute == 59);
            }
        }

        public List<TaskComment> Comments { get; set; }

        public string ToTaskPaperString()
        {
            string commentString = string.Join(Environment.NewLine, Comments.Select(comment => string.Format((string)"\t{0}", (object)comment.Content)));
            if (!(string.IsNullOrEmpty(commentString) || string.IsNullOrWhiteSpace(commentString))) commentString = string.Format("{0}{1}", Environment.NewLine, commentString);
            if (string.IsNullOrWhiteSpace(commentString)) commentString = string.Empty;
            string dateString = DueDateLocal.HasValue ? (IsAllDay ? DueDateLocal.Value.ToString("yyyy-MM-dd") : DueDateLocal.Value.ToString("yyyy-MM-dd hh:mm")) : string.Empty;
            return string.Format("- {0} @due({1}){2}", Content, dateString, commentString).Replace(@" @due()", string.Empty).Replace(@"@due()", string.Empty).Trim();
        }
    }
}