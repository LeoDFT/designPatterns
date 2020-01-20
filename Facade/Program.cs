using FacadePattern;
using System;

namespace Facade {
    class Program {
        static void Main(string[] args) {
    /*      Aquí crearemos todos nuestros objetos y los pasaremos como parámetro a nuestra clase
            fachada que sirve como la interfaz publica de los métodos. 

            Entra a la clase*/HomeTheaterFacade
            homeTheater = new HomeTheaterFacade(new Amplifier(), new DvdPlayer() ,new Projector(),
            new TheaterLights(), new PopcornPopper());

            //Una vez creada la fachada no necesitamos nada más, solo ejecutamos
            //sus métodos y vemos la magia

            homeTheater.WatchMovie("OP Stampede °w°");
            Console.WriteLine();
            Console.WriteLine("Presione una tecla para continuar...");
            Console.ReadLine();
            homeTheater.EndMovie();
            Console.ReadLine();
        }
    }
}
