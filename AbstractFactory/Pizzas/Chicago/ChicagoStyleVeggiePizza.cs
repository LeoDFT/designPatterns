using AbstractFactory.Ingredients;
using System;

namespace AbstractFactory.Pizzas {
    internal class ChicagoStyleVeggiePizza : Pizza {
        IPizzaIngredientsFactory ingredientFactory;
        public ChicagoStyleVeggiePizza(IPizzaIngredientsFactory ingredientFactory) {
            this.ingredientFactory = ingredientFactory;
        }

        public override void Prepare() {
            Name = "ChicagoStyl eVeggie Pizza";
            Dough = ingredientFactory.CreateDough();
            Sauce = ingredientFactory.CreateSauce();
            Cheese = ingredientFactory.CreateCheese();
        }

        public override void Cut() {
            Console.WriteLine("Cutting the pizza into square slices");
        }
    }
}