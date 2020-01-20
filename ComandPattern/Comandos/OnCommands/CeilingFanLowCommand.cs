using ComandPattern.Dispositivos;
using System;
using System.Collections.Generic;
using System.Text;

namespace ComandPattern.Comandos.OnCommands {
    public class CeilingFanLowCommand: ICommand {
        public CeilingFan CeilingFan { get; set; }
        public int prevSpeed;

        public CeilingFanLowCommand(CeilingFan CeilingFan) {
            this.CeilingFan = CeilingFan;
        }
        public void Execute() {
            CeilingFan.On();
            prevSpeed = CeilingFan.Speed;
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
