using Strategy.Ducks.Behaviors.Fly;
using Strategy.Ducks.Behaviors.Quack;
using Strategy.Ducks.Behaviors.Swim;
using System;
using System.Collections.Generic;
using System.Text;

namespace Strategy
{
    /* 
     Esta clase encapsula el comportamiento de todos los patos usando interfaces
    */
    public class Duck
    {
        /*
         Cada uno de los diferentes comportamientos de los patos tiene su propia clase
         y estos comportamientos son implementados por medio de la interfaz,
         de esta forma si queremos definir un nuevo comportamiento o tipo de comportamiento
         no afectara a los demás patos 

         entra en cualquiera de las interfaces 
        */

        public IFlyBehavior FlyBehavior { private get; set; }
        public IQuackBehavior QuackBehavior { private get; set; }
        public ISwimBehavior SwimBehavior { private get; set; }
        public Duck(){}
/*       Estos son comportamientos compartidos de los patos
         que gracias a la palabra reservada virtual puede ser 
         sobre escrito por cualquiera de las clases que lo
         implemente de manera explicita
         
         Entra a cualquiera de los tipos de pato para verlo mas a detalle 
*/
        public virtual void WhoIAm() {
            Console.WriteLine("I'm a X duck");
        }

        public virtual void Display() {
            WhoIAm();
            SwimBehavior.Swim();
            FlyBehavior.Fly();
            QuackBehavior.Quack();
        }
    }
}
