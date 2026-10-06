using System;
using System.Collections.Generic;
using System.Text;

namespace Part_01.src.OrderProcessor.OrderSave
{
    public class SqlOrderRepository : IOrderRepository
    {
        private static SqlOrderRepository _instance;
        private SqlOrderRepository()
        {
           
        }
        public static SqlOrderRepository GetInstance()
        {
            if (_instance == null)
            {
                _instance = new SqlOrderRepository();
            }
            return _instance;
        }
        public void Save(int orderId, DateTime processedAt) =>
            Console.WriteLine($"[SQL] save order {orderId} @ {processedAt:O}");
    }
}
