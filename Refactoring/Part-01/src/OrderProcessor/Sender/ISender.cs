using System;
using System.Collections.Generic;
using System.Text;

namespace Part_01.src.OrderProcessor.Sender
{
    internal interface ISender
    {
        public void Send(string to, string body);
    }
}
