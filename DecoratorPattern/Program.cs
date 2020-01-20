using DecoratorPattern.Beverages;
using DecoratorPattern.Condiments;
using System;

namespace DecoratorPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
               Aqui creamos las bebidas para adicionarlas con los decoradores 
               entra a la clase Espresso para analizarla
            */
            IBeverage beverage = new Espresso();
            Console.WriteLine(beverage.Description()+" $ "+beverage.Cost());
            IBeverage beverage2 = new DarckRoast();

            /*
             Aqui agregamos aditamentos a las bebidas  
             Entra  a la clase Mocha para analizar como
             es que se agrega la funcionalidad
             */
            beverage2 = new Mocha(beverage2);
            beverage2 = new Mocha(beverage2);
            beverage2 = new Whip(beverage2);
            Console.WriteLine(beverage2.Description() + " $ " + beverage2.Cost());

            IBeverage beverage3 = new HouseBlend();
            beverage3 = new Soy(beverage3);
            beverage3 = new Mocha(beverage3);
            beverage3 = new Whip(beverage3);
            Console.WriteLine(beverage3.Description() + " $ " + beverage3.Cost());
            Console.ReadLine();
        }
    }
}
