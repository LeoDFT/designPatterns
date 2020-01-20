using System;

namespace ComandPattern {
    internal class NoCommand : ICommand {
        public void Execute() {
            Console.WriteLine("Do nothing");
        }
        public void Undo() {
            Console.WriteLine("Do nothing");
        }
    }
}