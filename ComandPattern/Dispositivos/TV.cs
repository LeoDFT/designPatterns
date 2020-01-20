using System;

namespace ComandPattern.Comandos {
    public class TV {
        public void On() {
            Console.WriteLine("Turnning the Tv On");
        }
        public void Off() {
            Console.WriteLine("Turnning the Tv Off");
        }
    }
}