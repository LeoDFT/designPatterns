using DecoratorPattern.Beverages;
using System;
using System.Collections.Generic;
using System.Text;

namespace DecoratorPattern.Condiments
{
    public class Mocha : ICondimentDecorator
    {
        IBeverage beverage;
/*
        Como puedes ver los condimentos reciben como parametro 
        la bebida a la que seran adicionados, baja mas para ver
        como se aumenta el precio y descripcion en forma dinamica
*/
        public Mocha(IBeverage beverage)
        {
            this.beverage = beverage;
        }

/*      De esta forma es que se modifica el precio de la bebida
        conforme se le van agregando condimentos, cada condimento
        define su propio precio y descripcion que se agregan al
        precio original de la bebida,

        pero ¿cómo es esto posible si la interfaz que implementan
        los condimentos es diferente?

        entra a la interfaz ICondimentDecorator para analizarla
*/
        public double Cost()
        {
            return 0.20 + beverage.Cost();
        }

        public string Description()
        {
            return beverage.Description() + "Mocha";
        }
    }
}
