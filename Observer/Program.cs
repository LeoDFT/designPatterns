using Observer.Data;
using Observer.DisplayElements;
using System;

namespace Observer
{
    public class Program
    {
        public static void Main(string[] args)
        {
/*          Primero crearemos una instancia de los datos de la estación meteorológica,
            que es donde se mantienen registrados los observadores que desean ver su
            información.
            
            Entra a la clase WeatherData para verlo más a detalle y
            despues analiza la clase CurrentConditionsDisplay para ver
            como es el proceso de subscripcion */
            WeatherData weatherData = new WeatherData();
            CurrentConditionsDisplay currentDisplay =
                new CurrentConditionsDisplay(weatherData);
            //para poder observar los resultados asignamos y cabiamos los valores en las
            //mediciones de la estacion 
            weatherData.SetMeasurements(80, 65, 30.4f);
            weatherData.SetMeasurements(85, 70, 35.4f);
            weatherData.SetMeasurements(89, 75, 40.4f);
            Console.ReadLine();
        }
    }
}
