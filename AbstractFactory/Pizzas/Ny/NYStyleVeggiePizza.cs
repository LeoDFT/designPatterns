using AbstractFactory.Ingredients;

namespace AbstractFactory.Pizzas {
    internal class NYStyleVeggiePizza : Pizza {
        IPizzaIngredientsFactory ingredientFactory;
        public NYStyleVeggiePizza(IPizzaIngredientsFactory ingredientFactory) {
            this.ingredientFactory = ingredientFactory;
        }

        public override void Prepare() {
            Name = "NYStyle Veggie Pizza";
            Dough = ingredientFactory.CreateDough();
            Sauce = ingredientFactory.CreateSauce();
            Cheese = ingredientFactory.CreateCheese();
        }
    }
}