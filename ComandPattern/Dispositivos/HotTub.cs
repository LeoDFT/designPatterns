using System;

namespace ComandPattern.Comandos.OnCommands {
    public class HotTub {
        public void On() {
            Console.WriteLine("Turning on hot tub");
        }
        public void Off() {
            Console.WriteLine("Turning off hot tub");
        }
    }
}