using System;

//      Los arreglos al igual que en otros lenguajes de programacion son una estructura de datos iterable accedidos con un puntero y almacenado en susecivas
// posiciones. En C# los array solo pueden almacenar un tipo de dato. Los arreglos en C# son estaticos, es decir se debe reservar el espacio al momento de 
// iniciarlo y no puede ser modificado luego de esto.

//      Los arreglos implícitos son aquellos a los cuales no se les asigna ni un tipo de dato ni una cantidad de espacio reservado a la hora de ser creados
// sino que este proceso lo realiza el compilador en función del tipo y cantidad de elementos que le fueran asignados.


namespace _01_Arreglos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arreglo = new int[6];

            for(int i = 0; i < arreglo.Length; i++)
            {
                arreglo[i] = i;
                Console.WriteLine(arreglo[i]);
            } 
        }
    }
}
