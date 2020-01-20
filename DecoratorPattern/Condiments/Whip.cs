using DecoratorPattern.Beverages;
using System;
using System.Collections.Generic;
using System.Text;

namespace DecoratorPattern.Condiments
{
    public class Whip : ICondimentDecorator
    {
        IBeverage beverage;
        public Whip(IBeverage beverage)
        {
            this.beverage = beverage;
        }
        public double Cost()
        {
            return .10 + beverage.Cost();
        }

        public string Description()
        {
            return beverage.Description() + "Whip";
        }
    }
}
