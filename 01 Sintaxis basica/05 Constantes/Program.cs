using System;

//      Una constante a diferencia de una variable es un espacio de memoria reservado donde se almacena un valor que NO puede ni debe
// cambiar durante la ejecución del programa. Como nota, las estructuras de datos y los punteros almacenados en constantes tampoco
// cambian durante la ejecución del programa, aunque la información almacenada en las direcciones de memoria a los que estos apuntan
// si puede ser modificada.
// https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/const

namespace _05_Constantes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //  En C# para declarar una constante debemos usar la palabra reservada const. Las constantes deben declararse e iniciarse en la misma linea y
            // como buena práctica estas deben estar siempre escritas en mayúsculas.
            const double PI = 3.1416;

            //Console.WriteLine($"El valor de PI es: {PI} \n");


            //  Ejercicio de calculo de area de un circulo con entrada del area.
            double
                radio,
                result;

            Console.WriteLine("Ingrese la medida del radio: ");
            radio = double.Parse(Console.ReadLine());
            
            Console.WriteLine("\n");


            result = Math.Pow(radio, 2.0) * PI;
            Console.WriteLine($"El area del cirulo es igual a: {result} \n");
        }
    }
}
