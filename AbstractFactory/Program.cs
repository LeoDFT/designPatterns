using AbstractFactory.Pizzas;
using FactoryPattern.Stores;
using System;

namespace AbstractFactory {
    class Program {
        static void Main(string[] args) {
/*
        Entremos al pizzaStore
*/
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
