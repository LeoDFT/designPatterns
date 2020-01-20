using System;
using System.Collections.Generic;
using System.Text;

namespace ComandPattern.Comandos.OnCommands {
    public class TvOnCommand : ICommand {
        TV tv;
        public TvOnCommand(TV tv) {
            this.tv = tv;
        }
        public void Execute() {
            tv.On();
        }
        public void Undo() {
            tv.Off();
        }
    }
}
