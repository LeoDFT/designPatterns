using AbstractFactory.Ingredients;
using System;

namespace AbstractFactory.Pizzas {
    internal class ChicagoStyleClamPizza : Pizza {
        IPizzaIngredientsFactory ingredientFactory;
        public ChicagoStyleClamPizza(IPizzaIngredientsFactory ingredientFactory) {
            this.ingredientFactory = ingredientFactory;
        }
        public override void Prepare() {
            Name = "ChicagoStyleClamPizza";
            Dough = ingredientFactory.CreateDough();
            Sauce = ingredientFactory.CreateSauce();
            Cheese = ingredientFactory.CreateCheese();
            Clam = ingredientFactory.CreateClam();
        }
        public override void Cut() {
            Console.WriteLine("Cutting the pizza into square slices");
        }
    }
}