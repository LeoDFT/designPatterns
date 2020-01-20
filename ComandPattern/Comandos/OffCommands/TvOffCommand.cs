using System;
using System.Collections.Generic;
using System.Text;

namespace ComandPattern.Comandos.OffCommands {
    class TvOffCommand : ICommand {
        TV tv;
        public TvOffCommand(TV tv) {
            this.tv = tv;
        }
        public void Execute() {
            tv.Off();
        }
        public void Undo() {
            tv.On();
        }
    }
}
