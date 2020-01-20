using System;
using System.Collections.Generic;
using System.Text;

namespace DecoratorPattern.Beverages
{
    public class Espresso: IBeverage
    {
/*      Como puedes ver cualquier bebida define su propia descripción y costo
        implementando la interfaz IBeverage
*/
        public string Description() {
            return "Espresso";
        }

        public double Cost() {
            return 1.99;
        }
    }
}
