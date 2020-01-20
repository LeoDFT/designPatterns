using System;

namespace FacadePattern {
    public class TheaterLights {
        internal void Dim(int DimLevel) {
            Console.WriteLine("Diming lights to level" + DimLevel);
        }

        internal void On() {
            Console.WriteLine("Turning on lights");
        }
    }
}