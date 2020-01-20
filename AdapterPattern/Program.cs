using AdapterPattern.Duck;
using AdapterPattern.Turkey;
using System;

namespace AdapterPattern {
    class Program {
        static void Main(string[] args) {
/*      Aquí se crean el pato y el pavo, como puedes ver ambos implementan
        su propia interfaz con metodos como volar, graznar o gluglutear 

        Entra a las clases MallardDuck y WildTurkey
*/
            MallardDuck duck = new MallardDuck();
            WildTurkey turkey = new WildTurkey();

            //El adaptador convierte la interfaz de pato para ser utilizada por un pavo
            //sin problemas.

            //entra a la clase TurkeyAdapter
            IDuck turkeyAdapter = new TurkeyAdapter(turkey);

            //Aquí probaremos los métodos del pavo
            Console.WriteLine("The Turkey says...");
            turkey.Gobble();
            turkey.Fly();

            //Aquí probaremos los métodos del pato
            Console.WriteLine("\nThe Duck says...");
            TestDuck(duck);

            //Aquí probaremos los métodos el adaptador 
            //(llamamos los metodos del pato pero se ejecutan como pavo)
            Console.WriteLine("\nThe TurkeyAdapter says...");
            TestDuck(turkeyAdapter);
            Console.ReadKey();
            //Ejecuta el proyecto para ver el resultado
            //Como podrás ver se pudo utilizar la interfaz de pato para llamar métodos
            //de un pavo y esto no afecto el funcionamiento
        }

        static void TestDuck(IDuck duck) {
            duck.Quack();
            duck.Fly();
        }

        /*SUS CASOS DE USO MAS COMUNES SON CUANDO:
         ->se requiere utilizar una clase existente, pero su interfaz no coincide con la que se necesita.
         ->Crear una clase reutilizable que coopera con clases que no tienen interfaces compatibles. 
         ->Utilizar varias subclases existentes, pero como es poco práctico adaptar cada interfaz,
           se crea un objeto que adapte la interfaz de la clase padre.
         */
    }
}
