using AbstractFactory.Ingredients;

namespace AbstractFactory.Pizzas {
    internal class NYStyleCheesePizza : Pizza {
        IPizzaIngredientsFactory ingredientFactory;
        public NYStyleCheesePizza(IPizzaIngredientsFactory ingredientFactory) {
            this.ingredientFactory = ingredientFactory;
        }

        public override void Prepare() {
            Name = "NYStyleCheesePizza";
            Dough = ingredientFactory.CreateDough();
            Sauce = ingredientFactory.CreateSauce();
            Cheese = ingredientFactory.CreateCheese();
        }
    }
}