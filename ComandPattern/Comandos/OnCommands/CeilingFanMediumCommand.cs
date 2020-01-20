using ComandPattern.Dispositivos;
using System;
using System.Collections.Generic;
using System.Text;

namespace ComandPattern.Comandos.OnCommands {
    class CeilingFanMediumCommand: ICommand {
        public CeilingFan CeilingFan { get; set; }
        public int prevSpeed;

        public CeilingFanMediumCommand(CeilingFan CeilingFan) {
            this.CeilingFan = CeilingFan;
        }
        public void Execute() {
            prevSpeed = CeilingFan.Speed;
            CeilingFan.Medium();
        }
        public void Undo() {
            if (prevSpeed == CeilingFan.HIGH) {
                CeilingFan.High();
            } else if (prevSpeed == CeilingFan.MEDIUM) {
                CeilingFan.Medium();
            } else if (prevSpeed == CeilingFan.LOW) {
                CeilingFan.Low();
            } else if (prevSpeed == CeilingFan.OFF) {
                CeilingFan.Off();
            }
        }
    }
}
