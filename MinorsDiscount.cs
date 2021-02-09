using System;
using System.Collections.Generic;
using System.Text;

namespace Strategy_Pattern
{
    public class MinorsDiscount : IDiscountCalculator
    {
        public MinorsDiscount()
        {
        }

        public double calcDiscount(int amount)
        {
            return amount * 0.95;
        }
    }
}
