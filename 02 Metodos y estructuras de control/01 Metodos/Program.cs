using System;

//      Un método es un grupo de instrucciones que realiza una tarea concreta en un momento determinado (cuando
// sea invocado), identificado con un nombre específico.
//      En C# no existen los métodos globales, siempre deben existir dentro del contexto de una clase.
//      En C# método === función.

namespace _01_Metodos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"El resultado entre la suma de 3 y 2 es {sumaNumeros(3, 2)} \n");
            Console.WriteLine($"(Arrow Function) El resultado entre la suma de 3 y 2 es {sumaArrow(3, 2)}");
        }

        //  Su sintaxis consiste de el tipo de dato que devuelve, su nombre, parámetros y por último el bloque de código que
        // contiene sus instrucciones.


        //  Este método devolverá un dato de tipo entero 'int', se invocara con su nombre 'sumaNumeros' y recibe dos parámetros
        // de tipo entero '(int n1, int n2)'.
        static int sumaNumeros(int n1, int n2)
        {
            return n1 + n2;
        }

        //  La nomenclatura Arrow Function en C# solo funciona en una linea de codigo, al igual que en Js es un retrun implicito.
        static int sumaArrow(int n1, int n2) => n1 + n2; 
    }
}
