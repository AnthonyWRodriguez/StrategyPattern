using System;
using System.Collections.Generic;
using System.Text;

namespace Strategy_Pattern
{
    public class SeniorCitizenDiscount : IDiscountCalculator
    {
        public SeniorCitizenDiscount()
        {
        }

        public double calcDiscount(int amount)
        {
            return amount * 0.85;
        }
    }
}
