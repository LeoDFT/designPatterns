namespace Strategy
{
    public interface IFlyBehavior
    {
/*      Esta interfaz representa a la familia de algoritmos del comportamiento de vuelo del pato,
        Cada algoritmo se implementa en su propia clase y puede ser asignado en tiempo de ejecución,
        Cada uno de estos algoritmos representa una posible variación en el comportamiento de vuelo

        ir a las implementaciones dentro de la carpeta Behaviors para verlos más a detalle
*/
        void Fly();
    }
}