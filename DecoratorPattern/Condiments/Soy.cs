using DecoratorPattern.Beverages;
using System;
using System.Collections.Generic;
using System.Text;

namespace DecoratorPattern.Condiments
{
    public class Soy : ICondimentDecorator
    {
        IBeverage beverage;

        public Soy(IBeverage beverage)
        {
            this.beverage = beverage;
        }

        public double Cost()
        {
            return .15 + beverage.Cost();
        }

        public string Description()
        {
            return beverage.Description() + "Soy";
        }
    }
}
