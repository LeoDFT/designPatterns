using Observer.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace Observer.DisplayElements
{
    public class CurrentConditionsDisplay: IObserver, IDisplayElement
    {
        private float temperature;
        private float humidity;
        private ISubscribable weatherData;

        public CurrentConditionsDisplay(ISubscribable weatherData) {
            this.weatherData = weatherData;
            //de esta forma nos subscribimos al observable
            weatherData.SubscribeObserver(this);
        }

        public void Display()
        {
            //una vez que las mediciones cambian cada dispositivo
            //sabe como mostrar la infromacion que le intereza
            Console.WriteLine("Current Conditions are: \n" + temperature + "F degrees \n" + humidity + "% humidity");
        }

        public void Update(float temperature, float humidity, float pressure)
        {
            //Actualizamos los valores y los mostramos 
            this.temperature = temperature;
            this.humidity = humidity;
            Display();
        }
    }
}
