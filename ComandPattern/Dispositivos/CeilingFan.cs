using System;
using System.Collections.Generic;
using System.Text;

namespace ComandPattern.Dispositivos {
    public class CeilingFan {
        public const int HIGH = 3;
        public const int MEDIUM = 2;
        public const int LOW = 1;
        public const int OFF = 0;
        string location;
        public int Speed { get; set; }        public CeilingFan(string location = null) {
            this.location = location;
            Speed = OFF;
        }        public void High() {
            if (IsOff()) {
                this.On(HIGH);
            } else {
                Speed = HIGH;
            }
            Console.WriteLine("Ceilingfan speed High");
            // code to set fan to high
        }
        public void Medium() {
            if (IsOff()) {
                this.On(MEDIUM);
            } else {
                Speed = MEDIUM;
            }
            Console.WriteLine("Ceilingfan speed medium");
            // code to set fan to medium
        }
        public void Low() {
            if (IsOff()) {
                this.On(LOW);
            } else {
                Speed = LOW;
            }
            Console.WriteLine("Ceilingfan speed low");
            // code to set fan to low
        }
        public void On(int speed = LOW) {
            Console.WriteLine("Turning on Ceilingfan");
            Speed = speed;
        }
        public void Off() {
            Console.WriteLine("Turning off Ceilingfan");
            Speed = OFF;
        }

        private bool IsOff() {
            if (this.Speed == OFF) {
                return true;
            } else {
                return false;
            }
        }
    }
}
