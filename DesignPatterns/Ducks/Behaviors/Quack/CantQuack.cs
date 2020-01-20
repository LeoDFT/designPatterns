using System;
using System.Collections.Generic;
using System.Text;

namespace Strategy.Ducks.Behaviors.Quack
{
    public class CantQuack : IQuackBehavior
    {
        public void Quack()
        {
            //de esta forma se puede personalizar el comprotamiento del graznido
            Console.WriteLine("...<<Silence>>...");
        }
    }
}
