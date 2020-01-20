using System;
using System.Collections.Generic;
using System.Text;

namespace SingletonPattern {
    public class EagerChocolateBoiler {
/*
        una de las ventajas de instanciar el singleton de forma eager es
        que funciona de forma correcta con sistemas multi hilo pero
        sí es una clase muy pesada puede hacer que el sistema tarde un poco mas 
        al iniciar.

        * si el performance es importante no te recomiendo usar esta forma *

        veamos el método GetEagerChocolateBoiler para ver cómo se implementa
*/
        private static EagerChocolateBoiler chocolateBoiler = new EagerChocolateBoiler();
        private bool empty;
        private bool boiled;

        private EagerChocolateBoiler() {
            empty = true;
            boiled = false;
        }

        public static EagerChocolateBoiler GetEagerChocolateBoiler() {

            if (chocolateBoiler == null) {
                Console.WriteLine("EagerChocolateBoiler no esta instanciado");
            } else {
                Console.WriteLine("EagerChocolateBoiler ya existe");
            }
            /*notaras que la instancia de la clase se realiza desde la creacion del
            campo chocolateBoiler y este metodo solo fnciona como el punto de acceso
            global en el sistema*/
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
    }
}