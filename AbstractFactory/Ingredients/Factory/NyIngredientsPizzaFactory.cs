using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory.Ingredients.Factory {
    public class NyIngredientsPizzaFactory : IPizzaIngredientsFactory {
        public Cheese CreateCheese() {
             return new ReggianoCheese();
        }
        public Dough CreateDough() {
            return new ThinCrustDough();
        }
        public Sauce CreateSauce() {
            return new MarinaraSauce();
        }
        public Clams CreateClam() {
            return new FreshClams();
        }
        public Pepperoni CreatePepperoni() {
            return new SlicedPepperoni();
        }
        public Veggies[] CreateVeggies() {
            Veggies[] veggies = { new Garlic(), new Onion(), new Mushroom(), new RedPepper() };
            return veggies;
        }
    }
}
