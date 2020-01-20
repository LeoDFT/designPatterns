using FactoryPattern.Products;
using FactoryPattern.Stores;
using System;

namespace FactoryPattern {
    class Program {

        static void Main(string[] args) {
            //El factory method se trata de un método abstracto que se encarga de definir el valor retornado 
            //Entremos a la clase PizzaStore para verlo más a detalle
            PizzaStore nyStore = new NyPizzaStore();
            PizzaStore chicagoStore = new ChicagoPizzaStore();

            Pizza pizza = nyStore.OrderPizza("cheese");
            Console.WriteLine(pizza.Name);
            Console.WriteLine();
            pizza = chicagoStore.OrderPizza("cheese");
            Console.WriteLine(pizza.Name);
            Console.ReadLine();
        }
    }
}
