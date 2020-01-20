using System;

namespace ComandPattern.Dispositivos {
    public class LivingRoomLight: ILight {
        public void On() {
            Console.WriteLine("LivingRoomLight Light On");
        }

        public void Off() {
            Console.WriteLine("LivingRoomLight Light Off");
        }
    }
}