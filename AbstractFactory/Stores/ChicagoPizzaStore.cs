using AbstractFactory.Ingredients;
using AbstractFactory.Pizzas;
using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPattern.Stores {
    public class ChicagoPizzaStore : PizzaStore {
        //Cada sucursal conoce cual es su fabrica de ingredientes y lo pasa como parametro a la pizza
        //para obtener sus ingredientes especificos segun su estilo
        //En este punto las implementaciones son igual que el FactoryMethod.

        //NOTA: Aqui empieza lo importante del AbstractFactory
        //Entremos a la interfaz IPizzaIngredientsFactory para verlo mas a detalle
        IPizzaIngredientsFactory ingredientFactory = new ChicagoIngredientsPizzaFactory();
        public override Pizza CreatePizza(string type) {
            
            if (type == "cheese") {
                return new ChicagoStyleCheesePizza(ingredientFactory);
            } else if (type == "pepperoni") {
                return new ChicagoStylePepperoniPizza(ingredientFactory);
            } else if (type == "clam") {
                return new ChicagoStyleClamPizza(ingredientFactory);
            } else if (type == "veggie") {
                return new ChicagoStyleVeggiePizza(ingredientFactory);
            } else return null;
        }
    }
}
