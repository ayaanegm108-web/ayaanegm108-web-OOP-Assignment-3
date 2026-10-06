using System;
using System.Collections.Generic;
using System.Text;

namespace Part_01.src.OrderProcessor.OrderSave
{
    public interface IOrderRepository
    {
        public void Save(int orderId, DateTime processedAt);
    }
}
