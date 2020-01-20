using System;
using TemplatePattern.Beverages;
using TemplatePattern.Beverages.Coffe;
using TemplatePattern.Beverages.Tea;

namespace TemplatePattern {
    class Program {
        static void Main(string[] args) {
            /*Entra a la clase CaffeineBeverage*/
            CaffeineBeverage caffeineBeverage;
            Coffe coffe = new Coffe();
            Tea tea = new Tea();
            Coffe coffeWithMilk = new Coffe();
            Tea teaWithLemon = new Tea();
            Console.WriteLine("preparando Te (responder n)");
            tea.PrepareRecipe();
            Console.WriteLine("--------------------------------------------");
            Console.WriteLine("Preparando Cafe (responder n)");
            coffe.PrepareRecipe();
            Console.WriteLine("--------------------------------------------");
            Console.WriteLine("Preparando Cafe Con leche (responder y)");
            coffeWithMilk.PrepareRecipe();
            Console.WriteLine("--------------------------------------------");
            Console.WriteLine("preparando te con limon (responder y)");
            teaWithLemon.PrepareRecipe();
            Console.ReadLine();
            /*
             Ejecuta el proyecto y observa como usando el mismo algoritmo podemos 
             variar pequeños aspectos de su funcionalidad.
            */
        }
    }
}
