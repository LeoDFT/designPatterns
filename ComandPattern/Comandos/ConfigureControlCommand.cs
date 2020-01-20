using ComandPattern.Comandos.OffCommands;
using ComandPattern.Comandos.OnCommands;
using ComandPattern.Dispositivos;
using System;
using System.Collections.Generic;
using System.Text;

namespace ComandPattern.Comandos {
    public class ControlCommandFactory {
/*        Esta clase contiene toda la lógica de nuestro patrón comando,
          analicémosla detenidamente
*/
        public static RemoteControl CreateControl() {
/*         Nuestro control es nuestro invocador, es el que da comandos y
           los demás los ejecutan, veámoslo un poco más de cerca
           entra a la clase RemoteControl Para analizarla
*/
            RemoteControl control = new RemoteControl();

/*          Como pudiste ver el control no tiene ningún conocimiento de como 
            se realizan los comandos, lo único que hace es llamarlos y ejecutarlos,

            el siguiente proceso crea a los recibidores o accionadores que son los 
            que se encargan de ejecutar y hacer realidad nuestros comandos

            entra en las clases para analizarlas
*/
            ILight livingRoomLight = new LivingRoomLight();
            CeilingFan ceilingFan = new CeilingFan();
            ILight kitchenLight = new KitchenLight();
            GarageDoor garageDoor = new GarageDoor();
            Stereo stereo = new Stereo();
            ILight allLights = new AllLights();
            HotTub hotTub = new HotTub();
            TV tv = new TV();

/*          Como pudiste observar cada uno de estos receptores define como
            ejecutar sus acciones; acontinuacionel en siguiente proceso podrás  
            observar cómo se crean los comandos para ser almacenados dentro de nuestro
            control que funcionara como nuestro invocador.
*/
            //Este proceso crea los comandos, recibiendo como parametro
            //la clase que ejecutara el proceso(receptor)
            //Entra a LightsOnCommands para analizarlo
            LightsOnCommands livingRoomLightsOn = new LightsOnCommands(livingRoomLight);
            LightsOffCommands livingRoomLightsOff = new LightsOffCommands(livingRoomLight);
            LightsOnCommands kitchenLightsOn = new LightsOnCommands(kitchenLight);
            LightsOffCommands kitchenLightsOff = new LightsOffCommands(kitchenLight);
            LightsOnCommands allLightsOn = new LightsOnCommands(allLights);
            LightsOffCommands allLightsOff = new LightsOffCommands(allLights);

            CeilingFanLowCommand ceilingFanOn = new CeilingFanLowCommand(ceilingFan);
            CeilingFanMediumCommand ceilingFanMedium = new CeilingFanMediumCommand(ceilingFan);
            CeilingFanHightCommand ceilingFanHight = new CeilingFanHightCommand(ceilingFan);
            CeilingFanOffCommand ceilingFanOff = new CeilingFanOffCommand(ceilingFan);

            GarageDoorOpenCommand garageDoorOpen = new GarageDoorOpenCommand(garageDoor);
            GarageDoorCloseCommand garageDoorClose = new GarageDoorCloseCommand(garageDoor);

            StereoWithCDOnCommand stereoWithCDOn = new StereoWithCDOnCommand(stereo);
            StereoWithCDOffCommand stereoWithCDOff = new StereoWithCDOffCommand(stereo);

            HotTubOnCommand hotTubOn = new HotTubOnCommand(hotTub);
            HotTubOffCommand hotTubOff = new HotTubOffCommand(hotTub);

            TvOffCommand tvOff = new TvOffCommand(tv);
            TvOnCommand tvOn = new TvOnCommand(tv);

/*          para el modo fiesta necesitaremos un comando especial, que pueda recibir una
            serie de comandos y los ejecute, por eso fue creada la clase MacroCommand que 
            ejecuta una serie de comandos.
*/
            ICommand[] PartyModeCommandsOn = { livingRoomLightsOn, stereoWithCDOn, tvOn, hotTubOn };
            ICommand[] PartyModeCommandsOff = { livingRoomLightsOff, stereoWithCDOff, tvOff, hotTubOff };
            MacroCommand PartyModeOn = new MacroCommand(PartyModeCommandsOn);
            MacroCommand PartyModeOff = new MacroCommand(PartyModeCommandsOff);

            //Al almacenar los comandos en el control habilitamos la funcionalidad 
            //para que sea ejecutada al presionar algún boton, ve a la clase principal
            //del proyecto y ve cómo se ejecuta cada una de las acciones 
            control.OnCommands[0] = livingRoomLightsOn;
            control.OffCommands[0] = livingRoomLightsOff;
            control.OnCommands[1] = kitchenLightsOn;
            control.OffCommands[1] = kitchenLightsOff;
            control.OnCommands[2] = allLightsOn;
            control.OffCommands[2] = allLightsOff;
            control.OnCommands[3] = ceilingFanOn;
            control.OffCommands[3] = ceilingFanOff;
            control.OnCommands[4] = ceilingFanMedium;
            control.OffCommands[4] = ceilingFanOff;
            control.OnCommands[5] = ceilingFanHight;
            control.OffCommands[5] = ceilingFanOff;
            control.OnCommands[6] = garageDoorOpen;
            control.OffCommands[6] = garageDoorClose;
            control.OnCommands[7] = stereoWithCDOn;
            control.OffCommands[7] = stereoWithCDOff;
            control.OnCommands[8] = PartyModeOn;
            control.OffCommands[8] = PartyModeOff;
            control.OnCommands[9] = new NoCommand();
            control.OffCommands[9] = new NoCommand();
            return control;
        }
    }
}
