using System;
using System.Collections.Generic;
using System.Text;

namespace Strategy.Ducks.Behaviors.Swim
{
    public class CanSwim : ISwimBehavior
    {
        void ISwimBehavior.Swim()
        {
            //de esta forma se puede personalizar el comprotamiento del graznido
            Console.WriteLine("I'm Swimming!!");
        }
    }
}
