using System;
using System.Collections.Generic;
using System.Text;

namespace Part_01.src.Notifications
{

    public class SmsNotification : INotification
    {
        
            private NotificationType Type { get; set; }
            private SmsNotification(NotificationType type)
            {
                Type = type;
            }
            public static SmsNotification CreateSmsNotification(NotificationType type)
            {
                return new SmsNotification(type);
            }
            public void Send(string to, string message, DateTime? sendAt )
            {
                if (Type == NotificationType.Urgent)
                {
                    Console.WriteLine($"[sms] {to}: [URGENT] {message}");
                }
                else if (Type == NotificationType.Scheduled && sendAt.HasValue)
                {
                    Console.WriteLine($"[sms scheduled {sendAt.Value:g}] {to}: [URGENT] {message}");
                }
                else if(Type == NotificationType.Scheduled && !sendAt.HasValue)
                {
                Console.WriteLine($"you must state the hour for scheduled SMS ");
                }
                else if (Type == NotificationType.None)
                {
                    Console.WriteLine($"[sms] {to}: {message}");
                }
            }
    }
    
}
