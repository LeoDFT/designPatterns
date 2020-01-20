using ComandPattern.Dispositivos;
using System;
using System.Collections.Generic;
using System.Text;

namespace ComandPattern.Comandos.OffCommands {
    public class AllLightsOffCommand {
        public AllLights AllLights { get; set; }

        public AllLightsOffCommand(AllLights GarageDoor) {
            this.AllLights = AllLights;
        }
        public void Execute() {
            AllLights.Off();
        }

        public void Undo() {
            AllLights.On();
        }
    }
}
