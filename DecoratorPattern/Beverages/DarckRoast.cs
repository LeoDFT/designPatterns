using System;
using System.Collections.Generic;
using System.Text;

namespace DecoratorPattern.Beverages
{
    public class DarckRoast : IBeverage
    {
        public double Cost()
        {
            return 0.99;
        }

        public string Description()
        {
            return "DarckRoast";
        }
    }
}
