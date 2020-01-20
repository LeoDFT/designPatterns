using System;
using System.Collections.Generic;
using System.Text;

namespace SingletonPattern {
    public class ChocolateBoiler {
        private bool empty;
        private bool boiled;

        private ChocolateBoiler() {
            empty = true;
            boiled = false;
        }

        public void Fill() {
            if (IsEmpty()) {
                empty = false;
                boiled = false;
                // fill the boiler with a milk/chocolate mixture
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
