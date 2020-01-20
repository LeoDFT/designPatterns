using System;
using System.Collections.Generic;
using System.Text;

namespace Strategy.Ducks.Behaviors.Quack
{
    public class CanQuack : IQuackBehavior
    {
        void IQuackBehavior.Quack()
        {
            //de esta forma se puede personalizar el comprotamiento del graznido
            Console.WriteLine("Quack! Quack!");
        }
    }
}
