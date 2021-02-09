using System;
using System.Collections.Generic;
using System.Text;

namespace Strategy_Pattern
{
    class Context
    {
        private IDiscountCalculator _strategy;

        public Context() {}

        public void setStrategy(IDiscountCalculator strategy)
        {
            this._strategy = strategy;
        }

        public double calculate(int a)
        {
            return _strategy.calcDiscount(a);
        }
    }
}
