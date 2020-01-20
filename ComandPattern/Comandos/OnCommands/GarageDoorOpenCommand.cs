using ComandPattern.Dispositivos;
using System;
using System.Collections.Generic;
using System.Text;

namespace ComandPattern.Comandos.OnCommands {
    public class GarageDoorOpenCommand : ICommand {
        public GarageDoor GarageDoor { get; set; }

        public GarageDoorOpenCommand(GarageDoor GarageDoor) {
            this.GarageDoor = GarageDoor;
        }
        public void Execute() {
            GarageDoor.Open();
        }

        public void Undo() {
            GarageDoor.Close();
        }
    }
}
