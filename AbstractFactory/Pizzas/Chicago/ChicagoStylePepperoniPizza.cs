using AbstractFactory.Ingredients;
using System;

namespace AbstractFactory.Pizzas {
    internal class ChicagoStylePepperoniPizza : Pizza {
        IPizzaIngredientsFactory ingredientFactory;
        public ChicagoStylePepperoniPizza(IPizzaIngredientsFactory ingredientFactory) {
            this.ingredientFactory = ingredientFactory;
        }

        public override void Prepare() {
            Name = "ChicagoStyle Pepperoni Pizza";
            Dough = ingredientFactory.CreateDough();
            Sauce = ingredientFactory.CreateSauce();
            Cheese = ingredientFactory.CreateCheese();
        }

        public override void Cut() {
            Console.WriteLine("Cutting the pizza into square slices");
        }
    }
}