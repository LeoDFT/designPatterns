using FactoryPattern.Pizzas;
using FactoryPattern.Products;
using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPattern.Stores {
    public class NyPizzaStore : PizzaStore {

        //En este metodo se decide que tipo de pizza sera creda y se retorna como resultado
        protected override Pizza CreatePizza(string type) {
            if (type.Equals("cheese")) {
                return new NYStyleCheesePizza();
            } else if (type.Equals("veggie")) {
                return new NYStyleVeggiePizza();
            } else if (type.Equals("clam")) {
                return new NYStyleClamPizza();
            } else if (type.Equals("pepperoni")) {
                return new NYStylePepperoniPizza();
            } else return null;
        }
    }
}
