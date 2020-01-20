using DecoratorPattern.Beverages;
using System;
using System.Collections.Generic;
using System.Text;

namespace DecoratorPattern.Condiments
{
    public class SteamedMilk : ICondimentDecorator
    {
        IBeverage beverage;
        public SteamedMilk(IBeverage beverage)
        {
            this.beverage = beverage;
        }

        public double Cost()
        {
            return .10 + beverage.Cost();
        }

        public string Description()
        {
            return beverage.Description() + "Steamed Milk";
        }
    }
}
