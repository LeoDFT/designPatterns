using System;
using System.Collections.Generic;
using System.Text;

namespace ComandPattern.Comandos.OnCommands {
    public class HotTubOnCommand : ICommand {
        HotTub hotTub;

        public HotTubOnCommand(HotTub hotTub) {
            this.hotTub = hotTub;
        }
        public void Execute() {
            hotTub.On();
        }

        public void Undo() {
            hotTub.Off();
        }
    }
}
