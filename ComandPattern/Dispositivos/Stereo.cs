using System;

namespace ComandPattern.Dispositivos {
    public class Stereo {
        public void On() {
            Console.WriteLine("Turning on the stereo");
        }

        public void Off() {
            Console.WriteLine("Turning off the stereo");
        }

        public void Cd(string CdName = null) {
            Console.WriteLine("setting the cd " + CdName);
        }

        public void Volume(int predefinedVolume) {
            Console.WriteLine("Set volume at value " + predefinedVolume);
        }
    }
}