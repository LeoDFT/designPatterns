using System;
using System.Collections.Generic;
using System.Text;

namespace Strategy.Ducks.Behaviors.Fly
{
    public class CanNotFly : IFlyBehavior
    {
        //de esta forma se puede personalizar el comprotamiento del vuelo
        public void Fly()
        {
            Console.WriteLine("I can't fly");
        }
    }
}
