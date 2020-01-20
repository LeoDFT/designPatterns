using FactoryPattern.Products;

namespace FactoryPattern.Pizzas {
    internal class NYStyleCheesePizza : Pizza {
        public NYStyleCheesePizza() {
            Name = "NY Style Sauce and Cheese Pizza";
            Dough = "Thin Crust Dough";
            Sauce = "Marinara Sauce";
            Toppings.Add("Grated Reggiano Cheese");
        }
    }
}