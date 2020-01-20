using DecoratorPattern.Beverages;
using System;
using System.Collections.Generic;
using System.Text;

namespace DecoratorPattern.Condiments
{
/*
    ICondimentDecorator implementa la interfaz que IBeverage lo que nos permite 
    agregar condimentos de forma dinamica, esto es posible por que un condimento
    tendra siempre los mismos metodos que la bebida.
*/
    public interface ICondimentDecorator: IBeverage
    {}
}
