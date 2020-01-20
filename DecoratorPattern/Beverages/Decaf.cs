using System;
using System.Collections.Generic;
using System.Text;

namespace DecoratorPattern.Beverages
{
    public class Decaf : IBeverage
    {
        public double Cost()
        {
            return 1.05;
        }

        public string Description()
        {
            return "Decaf";
        }
    }
}
