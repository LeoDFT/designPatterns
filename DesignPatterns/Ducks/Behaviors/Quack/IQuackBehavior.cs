namespace Strategy
{
    public interface IQuackBehavior
    {
/*      Esta interfaz representa a la familia de algoritmos del comportamiento del graznido del pato,
        Cada algoritmo se implementa en su propia clase y puede ser asignado en tiempo de ejecución,
        Cada uno de estos algoritmos representa una posible variación en el comportamiento del Quack

        ir a las implementaciones dentro de la carpeta Behaviors para verlos más a detalle*/
        void Quack();
    }
}