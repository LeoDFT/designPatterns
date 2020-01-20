using System;

namespace SingletonPattern {
    public class DoubleCheckedChocolateBoiler {
/*
        el double check es una forma costosa de implementar el singleton,
        es importante analizar de forma correcta la situación para saber
        sí vale la pena implementarlo de esta manera, el double check 
        es la adaptación del metodo lazy para ser usada en sistemas multi hilos 

        analicemos el método GetDoubleCheckedChocolateBoiler para ver cómo se implementa
*/
        private static DoubleCheckedChocolateBoiler chocolateBoiler;
        private static object locker = new object();
        private bool empty;
        private bool boiled;

        private DoubleCheckedChocolateBoiler() {
            empty = true;
            boiled = false;
        }

        public static DoubleCheckedChocolateBoiler GetDoubleCheckedChocolateBoiler() {
            if (chocolateBoiler == null) {
                lock(locker) {
                    /*
                        el metodo lock nos permite bloquear un objeto para que solo 1 usuario tenga acceso 
                        a el y los demas tendran que esperar su turno para poder tomar su instancia
                    */
                    if (chocolateBoiler == null) {
                        /*
                         es importante revisar de nuevo la instanciacion de la clase ya que si 2 hilos
                         trataran de obtener la clase el primero bloquearia la creacion y el segundo
                         solo la consultaria  
                         */
                        Console.WriteLine("Creando Double_checkedChocolateBoiler");
                        chocolateBoiler = new DoubleCheckedChocolateBoiler();
                    } else {
                        Console.WriteLine("Double_checkedChocolateBoiler ya existe");
                    }
                }
            } else {
                Console.WriteLine("Double_checkedChocolateBoiler ya existe");
            }
            return chocolateBoiler;
        }

        public void Fill() {
            if (IsEmpty()) {
                empty = false;
                boiled = false;
                // fi ll the boiler with a milk/chocolate mixture
            }
        }
        public void Drain() {
            if (!IsEmpty() && IsBoiled()) {
                // drain the boiled milk and chocolate
                empty = true;
            }
        }
        public void Boil() {
            if (!IsEmpty() && !IsBoiled()) {
                // bring the contents to a boil
                boiled = true;
            }
        }

        public bool IsEmpty() {
            return empty;
        }
        public bool IsBoiled() {
            return boiled;
        }

        public static void Restart() {
            chocolateBoiler = null;
        }
    }
}