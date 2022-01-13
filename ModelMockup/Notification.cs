using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelMockup
{
    public class Notification
    {
        public Guid Id { get; set; }
        public NotificationStatus NotificationStatus { get; set; }
    }
    public enum NotificationStatus
    {
        Read,Unread
    }
}
