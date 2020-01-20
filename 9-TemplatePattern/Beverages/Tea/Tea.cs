using System;
using System.Collections.Generic;
using System.Text;

namespace TemplatePattern.Beverages.Tea {
    class Tea : CaffeineBeverage {
        protected override void AddCondiments() {
            Console.WriteLine("agregando Limon");
            Console.WriteLine();
        }

        protected override void Brew() {
            Console.WriteLine("Steeping the tea");
        }

        protected override bool CustomerWantsCondiments() {
            Console.Write("¿Le gustaria un toque de limon en su te? (y/n)");
            string result = Console.ReadLine();
            if (result != null) {
                if (result.ToLower().StartsWith("y")) {
                    return true;
                } else {
                    return false;
                }
            } else {
                return false;
            }
        }
    }
}
