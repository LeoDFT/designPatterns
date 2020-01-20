using ComandPattern.Dispositivos;
using System;
using System.Collections.Generic;
using System.Text;

namespace ComandPattern.Comandos.OnCommands {
    public class LightsOnCommands: ICommand {
        /*la interfaz ICommand es la pieza clave de este patron,
         * entra a la interfaz para analizarla
         */
        ILight light;
/*      Al pasarle como parámetro al constructor de nuestro comando 
        el receptor(en este caso la luz especifica que ejecutara el comando)
        lo único por lo que nos tenemos que preocupar es por llamar al método
        correcto, de esta manera el comando sabe que método llamar,
        de que objeto o dispositivo y como revertirlo.
*/
        public LightsOnCommands(ILight light) {
            this.light = light;
        }

        public void Execute() {
            light.On();
        }

        public void Undo() {
            light.Off();
        }
    }
}
