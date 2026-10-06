using System;
using System.Collections.Generic;
using System.Text;

namespace Part_01.src.Notifications
{
    public class EmailNotification : INotification
    {
        private NotificationType Type { get; set; }
        private EmailNotification(NotificationType type)
        {
            Type = type;
        }
        public  static EmailNotification CreateEmailNotification(NotificationType type)
        {
            return new EmailNotification(type);
        }
        public void Send(string to, string message, DateTime? sendAt = null)
        {
            if (Type == NotificationType.Urgent)
            {
                Console.WriteLine($"[email] {to}: [URGENT] {message}");
            }
            else if (Type == NotificationType.Scheduled && sendAt.HasValue)
            {
                Console.WriteLine($"[email scheduled {sendAt.Value:g}] {to}: [URGENT] {message}");
            }
            else if (Type == NotificationType.Scheduled && !sendAt.HasValue)
            {
                Console.WriteLine($"you must state the hour for scheduled email ");
            }
            else if (Type == NotificationType.None)
            {
                Console.WriteLine($"[email] {to}: {message}");
            }
        }
    }
}
