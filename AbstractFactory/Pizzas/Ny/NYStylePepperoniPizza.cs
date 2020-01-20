using AbstractFactory.Ingredients;

namespace AbstractFactory.Pizzas {
    internal class NYStylePepperoniPizza : Pizza {
        IPizzaIngredientsFactory ingredientFactory;
        public NYStylePepperoniPizza(IPizzaIngredientsFactory ingredientFactory) {
            this.ingredientFactory = ingredientFactory;
        }

        public override void Prepare() {
            Name = "NYStyle Pepperoni Pizza";
            Dough = ingredientFactory.CreateDough();
            Sauce = ingredientFactory.CreateSauce();
            Cheese = ingredientFactory.CreateCheese();
        }
    }
}