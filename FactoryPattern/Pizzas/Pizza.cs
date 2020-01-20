﻿using System;
using System.Collections.Generic;

namespace FactoryPattern.Products {
    public abstract class Pizza {
        //Establecemos las propiedades y metodos que contendran nuestras pizzas que
        //seran sobre escritos en cada tipo de pizza(de ser requerido) 
        //Entremos al ChicagoCheesePizza o a la NyStyleCheesepizza para verlo
        public string Name { get; set; }
        public string Dough { get; set; }
        public string Sauce { get; set; }
        public List<string> Toppings = new List<string>();

        public void Prepare() {
            Console.WriteLine("Preparing " + Name);
            Console.WriteLine("Tossing dough...");
            Console.WriteLine("Adding sauce...");
            Console.WriteLine("Adding toppings: ");
            foreach (var topping in Toppings) {
                Console.WriteLine(" " + topping);
            }
        }

        public void Bake() {
            Console.WriteLine("Bake for 25 minutes at 350");
        }
        public virtual void Cut() {
            Console.WriteLine("Cutting the pizza into diagonal slices");
        }

        public void Box() {
            Console.WriteLine("Place pizza in official PizzaStore box");
        }
    }
}