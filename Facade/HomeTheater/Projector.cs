using System;

namespace FacadePattern {
    public class Projector {
        internal void On() {
            Console.WriteLine("Turning on projector");
        }

        internal void WideScreenMode() {
            Console.WriteLine("WideScreenMode");
        }

        internal void Off() {
            Console.WriteLine("Turning off Projector");
        }
    }
}