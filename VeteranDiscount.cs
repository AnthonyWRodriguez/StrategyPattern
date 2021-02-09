using System;
using System.Collections.Generic;
using System.Text;

namespace Strategy_Pattern
{
    public class VeteranDiscount : IDiscountCalculator
    {
        public VeteranDiscount()
        {
        }

        public double calcDiscount(int amount)
        {
            return amount * 0.9;
        }
    }
}
