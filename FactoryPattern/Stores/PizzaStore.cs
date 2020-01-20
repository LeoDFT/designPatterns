using FactoryPattern.Products;
using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPattern.Stores {
    public abstract class PizzaStore {
        public Pizza OrderPizza(string type) {
            Pizza pizza;

            //El que toma la decisión de que pizza debería ser creada es el método créate pizza definido en cada sucursal
            //a diferencia del anterior, la decisión de que tipo de pizza crear se le deja a la tienda en si aplicando un factory
            pizza = CreatePizza(type);
            pizza.Prepare();
            pizza.Bake();
            pizza.Cut();
            pizza.Box();

            return pizza;
        }

        //Este es el método abstracto que se encarga de definir el tipo y estilo de pizza a crear,
        //se define en cada uno de los tipos de tienda creados

        //Entremos a alguna de las clases ChicagoPizzaStore o NyPizzaStore
        protected abstract Pizza CreatePizza(string type);

    }
}
