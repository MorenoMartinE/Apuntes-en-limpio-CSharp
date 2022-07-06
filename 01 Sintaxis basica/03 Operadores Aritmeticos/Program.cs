using System;

//      Los operadores básicos son + suma, - resta, * multiplicación, / división, % módulo. El único que puede ser utilizado
// en otro ámbito que no sea el numérico es el de suma, que actúa como un concatenador para variables de texto entre si mismas
// y con otros tipos de dato.


namespace TiposDeDatos
{
    class Program
    {
        static void Main(String[] Args)
        {
            int num1 = 2;
            int num2 = 3;


            Console.Write(num1 + num2 + "\n");
            Console.Write(num1 - num2 + "\n");
            Console.Write(num1 * num2 + "\n");
            Console.Write(num1 / num2 + "\n");                  // Si se dividen dos números enteros, el resultado sera un aproximado (redondeara ignorando el residuo)
            Console.Write((float)num1 / (float)num2 + "\n");    // De esta forma obtendremos el resultado correcto.
            Console.Write(num1 % num2 + "\n");

            //  Interpolación de variables dentro de cadena de caracteres
            Console.Write($"Esta es una variable interpolada {num1} dentro de un string \n");
        }
    }
}