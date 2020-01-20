using SimpleFactory.Pizzas;
using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleFactory.Stores {
    
    public class PizzaStore {
    //La clase PizzaFactory se encarga de la creación de las clases según el tipo que se le pase al ordenar la pizza
    //en el metodo OrderPizza(type)
        PizzaFactory factory;
        public PizzaStore(PizzaFactory factory) {
            this.factory = factory;
        }

        public Pizza OrderPizza(string type) {
            Pizza pizza;
            //Entra a la PizzaFactory para verlo más a detalle
            pizza = factory.CreatePizza(type);
            pizza.Prepare();
            pizza.Bake();
            pizza.Cut();
            pizza.Box();
            return pizza;
        }
    }
}
