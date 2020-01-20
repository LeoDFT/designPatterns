using Strategy.Ducks.Behaviors;
using System;
using System.Collections.Generic;
using System.Text;

namespace Strategy.Ducks
{
    public class RubberDuck: Duck
    {
        //De esta forma cada pato define su comportamiento
        public RubberDuck()
        {
            FlyBehavior = Behavior.CantFly();
            SwimBehavior = Behavior.CanSwim();
            QuackBehavior = Behavior.Squeak();
        }
        public override void WhoIAm()
        {
            Console.WriteLine("I'm a rubber duck");
        }
    }
}
