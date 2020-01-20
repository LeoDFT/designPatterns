using System;
using System.Collections.Generic;
using System.Text;

namespace Strategy.Ducks.Behaviors.Swim
{
    public class CantSwim : ISwimBehavior
    {
        public void Swim()
        {
            //de esta forma se puede personalizar el comprotamiento del graznido
            Console.WriteLine("I can't Swim");
        }
    }
}
