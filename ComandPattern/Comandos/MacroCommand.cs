using System;
using System.Collections.Generic;
using System.Text;

namespace ComandPattern.Comandos {
    public class MacroCommand : ICommand {
        ICommand[] Commands;

        public MacroCommand(ICommand[] Commands) {
            this.Commands = Commands;
        }
        public void Execute() {
            foreach (ICommand command in Commands) {
                command.Execute();
            }
        }

        public void Undo() {
            foreach (ICommand command in Commands) {
                command.Undo();
            }
        }
    }
}
