using System;
using System.Collections.Generic;
using System.Text;

namespace TemplatePattern.Beverages.Coffe {
    class Coffe : CaffeineBeverage {
/*      La clase café y te extienden de CaffeineBeverage, lo que les permite sobrescribir
        los métodos abstractos de su clase padre, esto nos permite personalizar los
        pasos sin alterar el flujo del algoritmo */
        protected override void AddCondiments() {
            Console.WriteLine("Agregando leche y azucar");
            Console.WriteLine();
        }

        protected override void Brew() {
            Console.WriteLine("Agregando cafe usando un filtro");
        }

        protected override bool CustomerWantsCondiments() {
            Console.Write("¿Le gustaria leche y azucar en su cafe? (y/n)");
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
