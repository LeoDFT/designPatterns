using ComandPattern.Dispositivos;
using System;
using System.Collections.Generic;
using System.Text;

namespace ComandPattern.Comandos.OnCommands {
    public class CeilingFanHightCommand: ICommand {
        public CeilingFan CeilingFan { get; set; }
        public int prevSpeed;

        public CeilingFanHightCommand(CeilingFan CeilingFan) {
            this.CeilingFan = CeilingFan;
        }
        public void Execute() {
            prevSpeed = CeilingFan.Speed;
            CeilingFan.High();
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
