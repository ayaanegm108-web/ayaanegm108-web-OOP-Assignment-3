using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Channels;

namespace Part_01.src.ShippingCost
{
    public interface IShippingCostCalculator
    {
        static decimal Calculate(decimal weightKg)=> throw new ArgumentException($"Unknown carrier ");
    }
}
