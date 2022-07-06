using System;

//      En C# podemos lanzar una excepcion de manera intencional durante la ejecución del programa con el uso de la palabra
// reservada throw.
// https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/throw
// https://docs.microsoft.com/es-es/dotnet/standard/exceptions/


namespace _02_Lanzamiento_de_excepciones
{
    internal class Program
    {
        static void Main(string[] args)
        {

            try
            {
                lanzamientoDeExcepcion();
            }catch (Exception ex)
            {
                Console.Error.WriteLine(ex.Message);
            }

        }



        public static void lanzamientoDeExcepcion()
        {
            throw new NullReferenceException(); // Esta excepción se está usando como ejemplo, pero se debería elegir la más adecuada según sea el caso.
        }

    }
}
