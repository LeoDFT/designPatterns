using Strategy.Ducks;
using System;

namespace DesignPatterns
{
    class Program {
        static void Main(string[] args)
        {
            /*Cada uno de los siguientes patos comparten comportamientos, pero no todos lo
             aplican de la misma manera.

            La herencia no es una opción debido a que cada nueva especie de pato agregado
            debería sobrescribir su comportamiento y si se quisiera hacer una modificación
            en el comportamiento todos deberían ser modificados 
            o alguien podría modificar el comportamiento de la clase padre y afectar a todos
            los demás,
            
            vamos a la clase Duck en la carpeta Ducks para ver cómo funciona*/

            AlabioDuck aliboDuck = new AlabioDuck();
            aliboDuck.Display();
            Console.WriteLine("presione cualquier tecla para continuar...");
            Console.ReadLine();
            MallardDuck mallardDuck = new MallardDuck();
            mallardDuck.Display();
            Console.WriteLine("presione cualquier tecla para continuar...");
            Console.ReadLine();
            RubberDuck rubberDuck = new RubberDuck();
            rubberDuck.Display();
            Console.WriteLine("presione cualquier tecla para continuar...");
            Console.ReadLine();
            WoodDuck woodDuck = new WoodDuck();
            woodDuck.Display();
            Console.WriteLine("FIN \npresione cualquier tecla para continuar...");
            Console.ReadLine();
            /*Cada uno de estos patos define su comportamiento, entra a cualquier clase de los patos para verlo*/
        }
    }
}
