using ComandPattern.Dispositivos;
using System;
using System.Collections.Generic;
using System.Text;

namespace ComandPattern.Comandos.OffCommands {
    public class GarageDoorCloseCommand : ICommand {
        public GarageDoor GarageDoor { get; set; }

        public GarageDoorCloseCommand(GarageDoor GarageDoor) {
            this.GarageDoor = GarageDoor;
        }
        public void Execute() {
            GarageDoor.Close();
        }

        public void Undo() {
            GarageDoor.Open();
        }
    }
}
