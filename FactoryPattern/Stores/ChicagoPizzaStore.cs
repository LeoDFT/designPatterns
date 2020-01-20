using FactoryPattern.Pizzas;
using FactoryPattern.Products;
using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPattern.Stores {
    public class ChicagoPizzaStore : PizzaStore {
        //En este metodo se decide que tipo de pizza sera creda y se retorna como resultado
        protected override Pizza CreatePizza(string type) {
            if (type == "cheese") {
                return new ChicagoStyleCheesePizza();
            } else if (type == "pepperoni") {
                return new ChicagoStylePepperoniPizza();
            } else if (type == "clam") {
                return new ChicagoStyleClamPizza();
            } else if (type == "veggie") {
                return new ChicagoStyleVeggiePizza();
            } else return null;
        }
    }
}
