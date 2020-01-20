using System;
using System.Collections.Generic;
using System.Text;

namespace Observer.Data
{
    //Los subscribibles(clases que seran observadas) necesitan implementar la interfaz ISubscribable
    public class WeatherData : ISubscribable 
    {
        //tenemos una lista de subscriptores (Observadores de la clase
        //(todos deben implementar la interfaz IObserver))
        private List<IObserver> observers;
        private float temperature;
        private float humidity;
        private float pressure;

        public WeatherData()
        {
            //Al crearse la clase se inicializa con una lista vacía de observadores
            this.observers = new List<IObserver>();
        }

        public void MeasuresChanged() {
            //Cuando las mediciones cambian se notifican a los observadores
            NotifyObservers();
        }

        public void SubscribeObserver(IObserver observer)
        {
            //se agregan observadores a la lista 
            observers.Add(observer);
        }

        public void UnSubscribeObserver(IObserver observer)
        {
            //se quitan observadores a la lista 
            observers.Remove(observer);
        }

        public void NotifyObservers()
        {
            //Por cada elemento que este suscrito que implemente la interfaz IObserver y
            //IDisplayElement se ejecutará la acción de actualización
            foreach (IObserver observer in observers)
            {
                observer.Update(temperature, humidity, pressure);
            }
        }

        public void SetMeasurements(float temperature, float humidity, float pressure) {
            //Se actualizan los valores de la estacion meteorologica y
            //desencadenamos el proceso de notificacion
            this.temperature = temperature;
            this.humidity = humidity;
            this.pressure = pressure;
            MeasuresChanged();
        }
    }
}
