using System;
using System.Collections.Generic;
using System.Text;

namespace TemplatePattern.Beverages {
    public abstract class CaffeineBeverage {
/*      Esta clase contiene el algoritmo especificado por el cliente 
        para la preparación de las bebidas con cafeína dentro del método 
        PrepareRecipe que sirve como nuestra plantilla
*/
        public void PrepareRecipe() {
            BoildWater();
            Brew();
            PourInCup();
            if (CustomerWantsCondiments()) {
                AddCondiments();
            }
        }
/*       Esta clase también define sus métodos de preparación,
         pero la magia de este patrón sucede cuando creamos métodos
         abstractos para que cada implementación pueda describir 
         su propio proceso

         Entra a la clase Coffe para ver como*/
        protected abstract bool CustomerWantsCondiments();
        protected abstract void AddCondiments();
        protected abstract void Brew();

        private void PourInCup() {
            Console.WriteLine("vaciando en taza");
        }
        private void BoildWater() {
            Console.WriteLine("Hirviendo agua");
        }
        
    }
}
