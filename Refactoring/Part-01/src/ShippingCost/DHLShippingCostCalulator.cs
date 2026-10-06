using System;
using System.Collections.Generic;
using System.Text;

namespace Part_01.src.ShippingCost
{
    public class DHLShippingCostCalulator : ICarrier
    {
        public static decimal Calculate(decimal weightKg)
        {
            return weightKg * 18m;
        }
    }
}
