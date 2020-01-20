using System;

namespace FacadePattern {
    public class PopcornPopper {
        internal void On() {
            Console.WriteLine("Turning on thePopcornPopper");
        }

        internal void Pop() {
            Console.WriteLine("Poping the pops");
        }

        internal void Off() {
            Console.WriteLine("Turning off thePopcornPopper");
        }
    }
}