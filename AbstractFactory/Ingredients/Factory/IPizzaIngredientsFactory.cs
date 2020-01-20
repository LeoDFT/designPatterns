using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory.Ingredients {
    public interface IPizzaIngredientsFactory {
        /*
         de esta manera cada estilo de pizza podra definir su familia de ingredientes especificos 
         (cada implementacion de la interfaz es una famila de ingredientes)

         para entender un poco mas esto veamos alguna de las fabricas de ingredientes
         ChicagoIngredientsPizzaFactory o  NyIngredientsPizzaFactory
        */
        Cheese CreateCheese();
        Dough CreateDough();
        Sauce CreateSauce();
        Veggies[] CreateVeggies();
        Pepperoni CreatePepperoni();
        Clams CreateClam();
    }
}
