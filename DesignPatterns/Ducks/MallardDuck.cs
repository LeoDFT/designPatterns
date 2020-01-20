using Strategy.Ducks.Behaviors;
using Strategy.Ducks.Behaviors.Fly;
using Strategy.Ducks.Behaviors.Quack;
using Strategy.Ducks.Behaviors.Swim;
using System;
using System.Collections.Generic;
using System.Text;

namespace Strategy.Ducks
{
    public class MallardDuck: Duck
    {
        //De esta forma cada pato define su comportamiento
        public MallardDuck()
        {
            /*
             * la clase behaviour encapsula los constructores de comportamiento de los patos
             */
            FlyBehavior = Behavior.CanFly();
            SwimBehavior = Behavior.CanSwim();
            QuackBehavior = Behavior.CanQuack();
        }
        public override void WhoIAm()
        {
            Console.WriteLine("Im mallarDuck");
        }
    }
}
