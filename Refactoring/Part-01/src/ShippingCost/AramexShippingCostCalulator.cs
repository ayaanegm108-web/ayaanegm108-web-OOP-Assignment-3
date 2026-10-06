using Part_01.src.OrderProcessor.Sender;
using System;
using System.Collections.Generic;
using System.Text;

namespace Part_01.src.ShippingCost
{
    internal class AramexShippingCostCalulator : IShippingCostCalculator
    {

        private static AramexShippingCostCalulator _instance;
        private AramexShippingCostCalulator()
        {

        }
        public static AramexShippingCostCalulator GetInstance()
        {
            if (_instance == null)
            {
                _instance = new AramexShippingCostCalulator();
            }
            return _instance;
        }
        public static decimal Calculate(decimal weightKg)
        {
            return weightKg * 12m;
        }
    }
}
