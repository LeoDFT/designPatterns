using Strategy.Ducks.Behaviors;
using System;
using System.Collections.Generic;
using System.Text;

namespace Strategy.Ducks
{
    public class WoodDuck: Duck
    {
        //De esta forma cada pato define su comportamiento
        public WoodDuck()
        {
            FlyBehavior = Behavior.CantFly();
            SwimBehavior = Behavior.CantSwim();
            QuackBehavior = Behavior.CantQuack();
        }
        public override void WhoIAm()
        {
            Console.WriteLine("I'm a wood duck");
        }
    }
}
