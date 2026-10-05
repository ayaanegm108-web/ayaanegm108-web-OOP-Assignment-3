using System;
using System.Collections.Generic;
using System.Text;

namespace Part_01
{
    internal class Notifications
    {
        public class Notification
        {
            public virtual void Send(string to, string message) =>
                Console.WriteLine($"{this.GetType().Name} {to}: {message}");
        }

        public class EmailNotification : Notification
        {
           
        }
        public class SmsNotification : Notification
        {
           
        }
        public class uregentNotification : Notification
        {
            public override void Send(string to, string message) =>
                base.Send(to, $"[URGENT] {message}");
        }
        public class UrgentEmailNotification : uregentNotification
        {
            public override void Send(string to, string message) =>
                base.Send(to, $"[URGENT] {message}");
        }

        public class UrgentSmsNotification : uregentNotification
        {
            public override void Send(string to, string message) =>
                base.Send(to, $"[URGENT] {message}");
        }

        public class UrgentScheduledEmailNotification : UrgentEmailNotification
        {
            public DateTime SendAt { get; set; }

            public override void Send(string to, string message) =>
                Console.WriteLine($"[{this.GetType().Name} scheduled {SendAt:g}] {to}: [URGENT] {message}");
        }

        public class UrgentScheduledSmsNotification : UrgentSmsNotification
        {
            public DateTime SendAt { get; set; }

            public override void Send(string to, string message) =>
                Console.WriteLine($"[sms scheduled {SendAt:g}] {to}: [URGENT] {message}");
        }
    }
}
