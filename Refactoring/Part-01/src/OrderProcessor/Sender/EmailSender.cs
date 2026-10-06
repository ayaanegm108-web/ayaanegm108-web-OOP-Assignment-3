using Part_01.src.OrderProcessor.OrderSave;
using System;
using System.Collections.Generic;
using System.Text;

namespace Part_01.src.OrderProcessor.Sender
{
    public class EmailSender:ISender
    {

        private static EmailSender _instance;
        private EmailSender()
        {

        }
        public static EmailSender GetInstance()
        {
            if (_instance == null)
            {
                _instance = new EmailSender();
            }
            return _instance;
        }
        public void Send(string to, string body) =>
        Console.WriteLine($"[SMTP] to={to} body={body}");
    }
}
