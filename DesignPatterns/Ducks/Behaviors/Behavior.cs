using Strategy.Ducks.Behaviors.Fly;
using Strategy.Ducks.Behaviors.Quack;
using Strategy.Ducks.Behaviors.Swim;
using System;
using System.Collections.Generic;
using System.Text;

namespace Strategy.Ducks.Behaviors
{
    //Esta clase encapsula los constructores de los comportamientos 
    //funciona como una especie del patrón factory
    public static class Behavior
    {
        public static IFlyBehavior CanFly()
        {
            return new CanFly();
        }
        public static IFlyBehavior CantFly()
        {
            return new CanNotFly();
        }
        public static ISwimBehavior CanSwim()
        {
            return new CanSwim();
        }
        public static ISwimBehavior CantSwim()
        {
            return new CantSwim();
        }
        public static IQuackBehavior CanQuack()
        {
            return new CanQuack();
        }
        public static IQuackBehavior CantQuack()
        {
            return new CantQuack();
        }
        public static IQuackBehavior Squeak()
        {
            return new Squeak();
        }
/*
         como puedes notar al usar la interfaz como tipo de valor devuelto en el metodo 
         podemos retornar cualquier clase que implemente esta interfaz. 
*/
    }
}
