using System;
using System.Collections.Generic;
using System.Text;

namespace Part_01.src.ShippingCost
{
    public class FedExShippingCostCalulator : IShippingCostCalculator
    {
        public static decimal Calculate(decimal weightKg)
        {
            return weightKg * 15m;
        }
    }
}
