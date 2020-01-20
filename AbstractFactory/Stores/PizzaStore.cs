using AbstractFactory.Pizzas;
using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPattern.Stores {
    public abstract class PizzaStore {
        public Pizza OrderPizza(string type) {
            Pizza pizza;

            //En este punto las implementaciones son igual que el FactoryMethod
            pizza = CreatePizza(type);
            pizza.Prepare();
            pizza.Bake();
            pizza.Cut();
            pizza.Box();

            return pizza;
        }

        //Este es el método abstracto que se encarga de definir el tipo y estilo de pizza a crear y
        //se define en cada uno de los tipos de tienda creados

        //Entremos al NyPizzaStore o al ChicagoPizzaStore
        public abstract Pizza CreatePizza(string type);

    }
}
