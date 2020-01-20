using System;

namespace FacadePattern {
    public class Amplifier {
        internal void On() {
            Console.WriteLine("Turning on Amplifier");
        }

        internal void SetDvd(DvdPlayer dvd) {
            Console.WriteLine("Setting dvd");
        }

        internal void SetSurroundSound() {
            Console.WriteLine("Setting SurroundSound");
        }

        internal void SetVolume(int v) {
            Console.WriteLine("Settingvolume level "+ v);
        }

        internal void Off() {
             Console.WriteLine("Turning off Amplifier");
        }
    }
}