using SimpleFactory.Pizzas;
using SimpleFactory.Stores;
using System;

namespace SimpleFactory {
/*   DEFINICION: Simple Factory permite la creación de objetos de un subtipo determinado a través de una clase Factory.
        Esto es especialmente útil cuando no sabemos, el subtipo que vamos a utilizar o
        cuando queremos delegar la lógica de creación de los objetos a una clase Factory.

        EJERCICIO DE EJEMPLO: Una cadena de pizzerías tiene un sistema para la preparación de sus pizzas

        Antes de comanzar piensa la forma en la que solucionarias el problema y comparala con la solucion implementada
        en este patron de diseño.

        Al terminar de leer intenta crear un dibujo de las clases y las relaciones de este patrón de diseño y comparalo con 
        el diagrama de este patron.
*/
    class Program {
        static void Main(string[] args) {
            PizzaStore store = new PizzaStore(new PizzaFactory());
            Pizza pizza = store.OrderPizza("cheese");
            Console.WriteLine(pizza.Name);
            Console.WriteLine();
            pizza = store.OrderPizza("clam");
            Console.WriteLine(pizza.Name);
            Console.ReadLine();
        }
    }
/*   NOTA:
     este tipo de factory no se considera como patron pero es una forma simple de desacoplar
     clientes de la instanciacion de las clases
*/
}
