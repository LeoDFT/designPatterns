using AbstractFactory.Ingredients;
using System;

namespace AbstractFactory.Pizzas{
    internal class ChicagoStyleCheesePizza : Pizza {
        IPizzaIngredientsFactory ingredientFactory;
        public ChicagoStyleCheesePizza(IPizzaIngredientsFactory ingredientFactory) {
            this.ingredientFactory = ingredientFactory;
        }

        public override void Prepare() {
            Name = "Chicago Style Deep Dish Cheese Pizza";
            Dough = ingredientFactory.CreateDough();
            Sauce = ingredientFactory.CreateSauce();
            Cheese = ingredientFactory.CreateCheese();
        }

        public override void Cut() {
            Console.WriteLine("Cutting the pizza into square slices");
        }
    }
}