using System;
using System.Collections.Generic;
using System.Text;

namespace DecoratorPattern.Beverages
{
    public interface IBeverage
    {
        double Cost();
        string Description();
    }
}
