using System;
using System.Collections.Generic;
using System.Text;

namespace ComandPattern {
    public interface ICommand {
/*  esta interfaz es la clave del patrón comando, todos nuestros
    comandos heredan de ella por lo que el control sabe que llamando
    al método ejecutar se accionará la acción deseada pero no sabe como
*/
        void Execute();
        void Undo();
    }
}
