using ComandPattern.Dispositivos;
using System;
using System.Collections.Generic;
using System.Text;

namespace ComandPattern.Comandos.OffCommands {
    public class CeilingFanOffCommand: ICommand {
        public CeilingFan CeilingFan { get; set; }

        public CeilingFanOffCommand(CeilingFan CeilingFan) {
            this.CeilingFan = CeilingFan;
        }
        public void Execute() {
            CeilingFan.Off();
        }

        public void Undo() {
            CeilingFan.On();
        }
    }
}
