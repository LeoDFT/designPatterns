using AbstractFactory.Ingredients.Factory;
using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory.Ingredients {
    public class ChicagoIngredientsPizzaFactory : IPizzaIngredientsFactory {
        public Cheese CreateCheese() {
            return new MozzarellaCheese();
        }
        public Clams CreateClam() {
            return new FrozenClams();
        }
        public Dough CreateDough() {
            return new ThickCrustDough();
        }
        public Pepperoni CreatePepperoni() {
            return new SlicedPepperoni();
        }
        public Sauce CreateSauce() {
            return new PlumTomatoSauce();
        }
        public Veggies[] CreateVeggies() {
            Veggies[] veggies = { new Garlic(), new Onion(), new Mushroom(), new Spinach(), new EggPlant(), new RedPepper() };
            return veggies;
        }
    }
}
