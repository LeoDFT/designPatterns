using AbstractFactory.Ingredients;

namespace AbstractFactory.Pizzas {
    internal class NYStyleClamPizza : Pizza {
        IPizzaIngredientsFactory ingredientFactory;
        public NYStyleClamPizza(IPizzaIngredientsFactory ingredientFactory) {
            this.ingredientFactory = ingredientFactory;
        }
        public override void Prepare() {
            Name = "NYStyleClamPizza";
            Dough = ingredientFactory.CreateDough();
            Sauce = ingredientFactory.CreateSauce();
            Cheese = ingredientFactory.CreateCheese();
            Clam = ingredientFactory.CreateClam();
        }
    }
}