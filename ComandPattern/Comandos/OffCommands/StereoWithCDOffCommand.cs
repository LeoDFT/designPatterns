using ComandPattern.Dispositivos;
using System;
using System.Collections.Generic;
using System.Text;

namespace ComandPattern.Comandos.OffCommands {
    class StereoWithCDOffCommand : ICommand {
        public Stereo Stereo { get; set; }
        public StereoWithCDOffCommand(Stereo stereo) {
            this.Stereo = stereo;
        }
        public void Execute() {
            Stereo.Off();
        }

        public void Undo() {
            Stereo.On();
        }
    }
}
