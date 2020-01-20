using Strategy.Ducks.Behaviors;
using System;
using System.Collections.Generic;
using System.Text;

namespace Strategy.Ducks
{
    public class AlabioDuck: Duck
    {

        //De esta forma cada pato define su comportamiento
        public AlabioDuck()
        {
            FlyBehavior = Behavior.CanFly();
            SwimBehavior = Behavior.CanSwim();
            QuackBehavior = Behavior.CanQuack();
        }
        public override void WhoIAm()
        {
            Console.WriteLine("I'm a Alabio Duck");
        }
    }
}
