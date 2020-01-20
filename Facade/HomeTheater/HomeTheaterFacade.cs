using System;
using System.Collections.Generic;
using System.Text;

namespace FacadePattern {
/*
    Esta clase se encarga de orquestar el funcionamiento del subsistema, proporcionando
    un punto de acceso público el cual no interfiere con el funcionamiento especifico
    de cada parte del sub sistema, lo que significa que si se desea podría manipularse
    cada clase de manera individual y el patrón de diseño facade seguirá funcionando.
*/
    public class HomeTheaterFacade {
        Amplifier amp;
        DvdPlayer dvd;
        Projector projector;
        TheaterLights lights;        PopcornPopper popper;

        public HomeTheaterFacade(Amplifier amp,DvdPlayer dvd,
        Projector projector, TheaterLights lights,
        PopcornPopper popper)
        {
            this.amp = amp;
            this.dvd = dvd;
            this.projector = projector;
            this.lights = lights;
            this.popper = popper;
        }

        //Definimos los métodos del subsistema a ejecutar en cada punto de acceso de la fachada
        //Encendemos y preparamos todo para iniciar la película
        public void WatchMovie(string movie) {
            Console.WriteLine("Get ready to watch a movie...");
            popper.On();
            popper.Pop();
            lights.Dim(10);
            projector.On();
            projector.WideScreenMode();
            amp.On();
            amp.SetDvd(dvd);
            amp.SetSurroundSound();
            amp.SetVolume(5);
            dvd.On();
            dvd.Play(movie);
        }

        //Apagamos todo al finalizar la pelicula
        public void EndMovie() {
            Console.WriteLine("Shutting movie theater down...");
            popper.Off();
            lights.On();
            projector.Off();
            amp.Off();
            dvd.Stop();
            dvd.Eject();
            dvd.Off();
        }
    }
}
