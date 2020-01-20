using AdapterPattern.Duck;
using AdapterPattern.Turkey;
using System;
using System.Collections.Generic;
using System.Text;

namespace AdapterPattern {
    public class TurkeyAdapter : IDuck {
        ITurkey turkey;

        public TurkeyAdapter(ITurkey turkey) {
            this.turkey = turkey;
        }

        //Aquí hacemos la conversión de los metodos implementados por el pato y los transformamos a
        //los métodos implementados por el pavo
        public void Fly() {
           turkey.Fly();
        }

        public void Quack() {
            turkey.Gobble();
        }
    }
}
