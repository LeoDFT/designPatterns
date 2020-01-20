using System;

namespace ComandPattern.Dispositivos {
    public class KitchenLight: ILight {
        public void On() {
            Console.WriteLine("KitchenLight Light On");
        }

        public void Off() {
            Console.WriteLine("KitchenLight Light Off");
        }
    }
}