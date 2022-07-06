using System;

//      Para captura y manejo de errores, en C# también se utiliza un bloque try-catch. Funciona de manera muy similar a Js,
// el código luego del bloque se seguirá ejecutando salvo se indique lo contrario. Como peculiaridad se pueden crear tantos bloques
// catch como se considere necesario y especificar ante qué tipo de excepción o error debe ejecutarse el código dentro de cada uno.
// En el caso de este ejemplo se hace uso una excepción genérica de la clase Exeption (La clase Exeption es el padre de todas las
// demás clases de excepción).
//      Puede usarse la palabra reservada checked para cambiar dentro de un bloque de codigo el comportamiento por defecto del compilador
// de C# (Este por defecto ignorara las excepciones de tipo overflow debido a que un chequeo constante en tiempo de ejecución de todas las
// operaciones aritméticas del programa sería muy costoso en términos del uso de los recursos del ordenador). Se puede conseguir un resultado
// muy similar configurando el compilador para que compruebe en todas las operaciones aritméticas del programa esta excepción. Aunque no es
// recomendable que se lleve a un ámbito de producción (En este caso si queremos que un bloque de código no siga este comportamiento debemos de
// utilizar la palabra reservada unchecked).
//		También como en otros lenguajes, puede agregar opcionalmente un último bloque a la estructura try catch. Este es el bloque finally y
// el código que éste contenga se ejecutará indiferentemente de si existió o no una excepción durante el bloque try.
// https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/try-catch


namespace _01_Manejo_de_errores
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int num;
            Console.WriteLine("Ingrese un valor no numerico para generar un error: ");
           

            try 
            { 
                num = int.Parse(Console.ReadLine());
            }
            catch(Exception ex)
            {
                Console.Error.WriteLine(ex.Message);
                Console.WriteLine("Este es el bloque de codigo que se ejecuta al encontrar un error durante la ejecucion del bloque try.");
            }

            Console.WriteLine("\n");
            Console.WriteLine("Codigo luego del bloque try catch.");
        }
    }
}
