using ComandPattern.Dispositivos;
using System;
using System.Collections.Generic;
using System.Text;

namespace ComandPattern.Comandos.OffCommands {
    public class LightsOffCommands : ICommand {
        ILight light;

        public LightsOffCommands(ILight light) {
            this.light = light;
        }

        public void Execute() {
            light.Off();
        }

        public void Undo() {
            light.On();
        }
    }
}
