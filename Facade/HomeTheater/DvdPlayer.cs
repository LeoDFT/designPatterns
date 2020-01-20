using System;

namespace FacadePattern {
    public class DvdPlayer {
        internal void On() {
            Console.WriteLine("turning on dvd");
        }

        internal void Play(string movie) {
            Console.WriteLine("paying movie " + movie);
        }

        internal void Stop() {
             Console.WriteLine("Stopping movie");
        }

        internal void Eject() {
            Console.WriteLine("Ejecting movie");
        }

        internal void Off() {
            Console.WriteLine("Turning off dvd");
        }
    }
}