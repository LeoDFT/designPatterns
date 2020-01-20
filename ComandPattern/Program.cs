using ComandPattern.Comandos;
using System;

namespace ComandPattern {
    class Program {
        //Para iniciar analizando este patron entra a la clase ControlCommandFactory
        static void Main(string[] args) {
            //la clase control factory se encarga de crear el control y
            //establecer todos los comandos en cada boton del control
            RemoteControl control = ControlCommandFactory.CreateControl();

            //ejecuta el proyecto para ver el resultado
            control.OnButtonWasPushed(0);
            control.OffButtonWasPushed(0);
            control.UndoButtonWasPushed();
            control.OnButtonWasPushed(1);
            control.OffButtonWasPushed(1);
            control.OnButtonWasPushed(2);
            control.OffButtonWasPushed(2);
            control.UndoButtonWasPushed();
            control.OnButtonWasPushed(3);
            control.OffButtonWasPushed(3);
            control.OnButtonWasPushed(4);
            control.UndoButtonWasPushed();
            control.OffButtonWasPushed(4);
            control.OnButtonWasPushed(5);
            control.UndoButtonWasPushed();
            control.OffButtonWasPushed(5);
            control.OnButtonWasPushed(6);
            control.OffButtonWasPushed(6);
            control.OnButtonWasPushed(7);
            control.OffButtonWasPushed(7);
            Console.WriteLine("--ParyMode On--");
            control.OnButtonWasPushed(8);
            Console.WriteLine("--ParyMode Off--");
            control.OffButtonWasPushed(8);
            Console.WriteLine("--Undo ParyMode--");
            control.UndoButtonWasPushed();

            control.OnButtonWasPushed(9);
            control.OffButtonWasPushed(9);
            control.UndoButtonWasPushed();

            Console.ReadKey();
        }
    }
}
