using Part_01.src.OrderProcessor.OrderSave;
using Part_01.src.OrderProcessor.Sender;
using System;
using System.Collections.Generic;
using System.Text;

namespace Part_01.src.OrderProcessor
{
    internal class OrderProcessor
    {
        private readonly IOrderRepository _repo;
        private readonly ISender _send;

        public OrderProcessor(IOrderRepository repo, ISender send)
        {
            _repo = repo;
            _send = send;
        }

        public void Process(int orderId, string customerDetails)
        {
            _repo.Save(orderId, DateTime.Now);
            _send.Send(customerDetails, $"Order {orderId} confirmed at {DateTime.Now}");
        }
    }
    
}
