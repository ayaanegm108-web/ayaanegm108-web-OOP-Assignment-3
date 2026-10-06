using System;
using System.Collections.Generic;
using System.Text;

namespace Part_01.src.Notifications
{
   public enum NotificationType
    {
        None = 0,
        Urgent = 1,
        Scheduled = 2
    }
    public interface INotification
    {
        public void Send(string to, string message, DateTime? sendAt = null);
    }

}
