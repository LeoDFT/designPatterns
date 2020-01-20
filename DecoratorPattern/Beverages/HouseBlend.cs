using System;
using System.Collections.Generic;
using System.Text;

namespace DecoratorPattern.Beverages
{
    public class HouseBlend : IBeverage
    {
        public double Cost()
        {
            return 0.89;
        }

        public string Description()
        {
            return "HouseBlend";
        }
    }
}
