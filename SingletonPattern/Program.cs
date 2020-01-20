using System;
using System.Threading;

namespace SingletonPattern {
    class Program {
/*      Antes de comenzar Entra a la clase ChocolateBoiler para analizarla.    
        cómo puedes ver la caldera define sus estados si está lleno o si se está 
        hirviendo la mezcla, pero que sucede si decidimos crear otra clase de la
        caldera mientras esta está siendo hervida? (los valores se restablecerán y
        sucederá una catástrofe).
*/
        static void Main(string[] args) {
            //Probaremos los diferentes tipos de singleton y explicaremos sus pros y contras
            //entra a cada una de las clases(LazyChocolateBoiler y EagerChocolateBoiler) 
            //para ver las explicaciones

            Console.WriteLine("LazyChocolateBoiler example");
            LazyChocolateBoiler.GetLazyChocolateBoiler();
            LazyChocolateBoiler.GetLazyChocolateBoiler();
            Console.ReadLine();

            Console.WriteLine("EagerChocolateBoiler example");
            EagerChocolateBoiler.GetEagerChocolateBoiler();
            EagerChocolateBoiler.GetEagerChocolateBoiler();
            Console.ReadLine();

            //ahora revisaremos el mismo lazy y el mismo eager con sistemas multi hilos
            Console.WriteLine("now using multithreads and LazyChocolateBoiler");
            // proceso de preparacion para miltiples hilos
            LazyChocolateBoiler.Restart();
            ThreadStart lazyMethodToThread = new ThreadStart(GetLazyChocolateBoiler);
            Thread lazyFistThread = new Thread(lazyMethodToThread);
            Thread lazySecondThread = new Thread(lazyMethodToThread);
            //fin del proceso de preparacion para miltiples hilos
            lazyFistThread.Start();
            lazySecondThread.Start();
            Console.ReadLine();
            //una de las debilidades del lazy es que en sistemas multi hilos 
            //si se realizan mas de 2 peticiones simultaneas podrían crearse varias instancias
            //de la clase, lo que causaría que ya no fuera singleton y el chocolate podría derramarse

            Console.WriteLine("now using multithreads and EagerChocolateBoiler");
            // proceso de preparacion para miltiples hilos
            ThreadStart eagerMethodToThread = new ThreadStart(GetEagerChocolateBoiler);
            Thread eagerFistThread = new Thread(eagerMethodToThread);
            Thread eagerSecondThread = new Thread(eagerMethodToThread);
            //fin del proceso de preparacion para miltiples hilos
            eagerFistThread.Start();
            eagerSecondThread.Start();
            Console.ReadLine();

            /*
             para entrar a la clase de este singleton ve al metodo GetDoublecheckedChocolateBoiler
             */
            Console.WriteLine("now using multithreads and Double_checkedChocolateBoile");
            //proceso de preparacion para miltiples hilos
            ThreadStart Double_checkedMethodToThread = new ThreadStart(GetDoublecheckedChocolateBoiler);
            Thread DoubleCheckedFistThread = new Thread(Double_checkedMethodToThread);
            Thread DoubleCheckedSecondThread = new Thread(Double_checkedMethodToThread);
            //fin del proceso de preparacion para miltiples hilos
            DoubleCheckedFistThread.Start();
            DoubleCheckedSecondThread.Start();
            Console.ReadLine();
        }

        //estos metodos solo nos permiten cumplir con los requerimientos
        //para usar los multiples hilos 
        static void GetEagerChocolateBoiler() {
            EagerChocolateBoiler.GetEagerChocolateBoiler();
        }

        static void GetLazyChocolateBoiler() {
            LazyChocolateBoiler.GetLazyChocolateBoiler();
        }

        static void GetDoublecheckedChocolateBoiler() {
            DoubleCheckedChocolateBoiler.GetDoubleCheckedChocolateBoiler();
        }
    }
}
