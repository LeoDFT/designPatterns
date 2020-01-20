using System;
using System.Collections.Generic;
using System.Text;

namespace ComandPattern.Dispositivos {
    public class AllLights: ILight {
        public void On() {
            Console.WriteLine("Turning on AllLights");
        }
        public void Off() {
            Console.WriteLine("Turning off AllLights");
        }
    }
}
