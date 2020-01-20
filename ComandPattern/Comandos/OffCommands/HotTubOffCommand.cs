using ComandPattern.Comandos.OnCommands;
using System;
using System.Collections.Generic;
using System.Text;

namespace ComandPattern.Comandos.OffCommands {
    public class HotTubOffCommand : ICommand {
        HotTub hotTub;

        public HotTubOffCommand(HotTub hotTub) {
            this.hotTub = hotTub;
        }
        public void Execute() {
            hotTub.Off();
        }

        public void Undo() {
            hotTub.On();
        }
    }
}
