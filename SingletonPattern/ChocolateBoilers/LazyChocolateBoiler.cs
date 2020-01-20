using System;
using System.Collections.Generic;
using System.Text;

namespace SingletonPattern {
    public class LazyChocolateBoiler {
/*
        Una de las ventajas de instanciar una clase singleton de forma lazy es
        que se crea la instancia únicamente hasta que es requerido y no antes,
        sin embargo este método no funciona correctamente en sistemas multi hilo

        * si el performance es importante esta puede ser la mejor manera de hacerlo *

        veamos el método GetLazyChocolateBoiler para ver cómo se implementa
*/
        private static LazyChocolateBoiler chocolateBoiler;
        private bool empty;
        private bool boiled;

        private LazyChocolateBoiler() {
            empty = true;
            boiled = false;
        }

        public static LazyChocolateBoiler GetLazyChocolateBoiler() {
            if (chocolateBoiler == null) {
                Console.WriteLine("Creando LazyChocolateBoiler");
                chocolateBoiler = new LazyChocolateBoiler();
            } else {
                Console.WriteLine("LazyChocolateBoiler ya existe");
            }
            //Este metodo a diferencia del eager se encarga de la creacion de la clase 
            //y a demas funciona como el punto de acceso global en el sistema
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
            //solo necesario por motivos del ejemplo
            chocolateBoiler = null;
        }
    }
}
