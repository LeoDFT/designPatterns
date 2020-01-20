using ComandPattern.Dispositivos;
using System;
using System.Collections.Generic;
using System.Text;

namespace ComandPattern.Comandos.OnCommands {
    public class AllLightsOnCommand {
        public AllLights AllLights { get; set; }

        public AllLightsOnCommand(AllLights GarageDoor) {
            this.AllLights = AllLights;
        }
        public void Execute() {
            AllLights.On();
        }

        public void Undo() {
            AllLights.Off();
        }
    }
}
