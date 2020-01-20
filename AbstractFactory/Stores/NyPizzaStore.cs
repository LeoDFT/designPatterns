using AbstractFactory.Ingredients;
using AbstractFactory.Ingredients.Factory;
using AbstractFactory.Pizzas;
using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPattern.Stores {
    public class NyPizzaStore : PizzaStore {
        IPizzaIngredientsFactory ingredientFactory = new NyIngredientsPizzaFactory();

        //Cada sucursal conoce cual es su fabrica de ingredientes y lo pasa como parametro a la pizza
        //para obtener sus ingredientes especificos segun su estilo

        //Entremos a la interfaz IPizzaIngredientsFactory para verlo mas a detalle
        public override Pizza CreatePizza(string type) {
            if (type.Equals("cheese")) {
                return new NYStyleCheesePizza(ingredientFactory);
            } else if (type.Equals("veggie")) {
                return new NYStyleVeggiePizza(ingredientFactory);
            } else if (type.Equals("clam")) {
                return new NYStyleClamPizza(ingredientFactory);
            } else if (type.Equals("pepperoni")) {
                return new NYStylePepperoniPizza(ingredientFactory);
            } else return null;
        }
    }
}
