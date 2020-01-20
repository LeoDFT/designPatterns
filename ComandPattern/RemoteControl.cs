using System;
using System.Collections.Generic;
using System.Text;

namespace ComandPattern {
    public class RemoteControl {
/*     Como podemos ver nuestro control remoto(invocador) contiene comandos 
       y los ejecuta, pero no sabe quien o como, solo sabe que si los llama
       se realizara el comando que ha solicitado.
*/
        //comandos para encender o iniciar un proceso
        public ICommand[] OnCommands { get; set; }
        //comandos para apagar o finalizar un proceso
        public ICommand[] OffCommands { get; set; }
        //comando para revertir el comando llamado anteriormente
        public ICommand UndoCommand { get; set; }

        public RemoteControl() {
/*          al crear un control este no define ninguna acción,
            por eso se inicializa con comandos vacíos,
            aquí se utiliza un objeto vacío que no realiza
            ninguna acción para evitarle al cliente la lógica
            de analizar si el comando este vacío
*/
            OnCommands = new ICommand[10];
            OffCommands = new ICommand[10];
            ICommand noCommand = new NoCommand();
            for (int i = 0; i < 10; i++) {
                OnCommands[i] = noCommand;
                OffCommands[i] = noCommand;
            }
            UndoCommand = new NoCommand();
        }

        //estos métodos se encargan de ejecutar los comandos 
        //almacenados en el botón presionado por el usuario
        public void OnButtonWasPushed(int slot) {
            OnCommands[slot].Execute();
            UndoCommand = OnCommands[slot];
        }

        public void OffButtonWasPushed(int slot) {
            OffCommands[slot].Execute();
            UndoCommand = OffCommands[slot];
        }

        public void UndoButtonWasPushed() {
            Console.Write("Undo ");
            UndoCommand.Undo();
        }
    }
}
