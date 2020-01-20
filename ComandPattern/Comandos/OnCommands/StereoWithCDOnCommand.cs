using ComandPattern.Dispositivos;
using System;
using System.Collections.Generic;
using System.Text;

namespace ComandPattern.Comandos.OnCommands {
    class StereoWithCDOnCommand : ICommand {
        public Stereo Stereo { get; set; }
        private readonly int predefinedVolume = 11;
        public StereoWithCDOnCommand(Stereo stereo) {
            this.Stereo = stereo;
        }
        public void Execute() {
            Stereo.On();
            Stereo.Cd();
            Stereo.Volume(predefinedVolume);
        }

        public void Undo() {
            Stereo.Off();
        }
    }
}
