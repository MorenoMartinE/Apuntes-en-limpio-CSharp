using System;

//      Los delegados comparten muchas cualidades de los punteros a metodos. Algunas de sus utilidades son ser utilizados para llamar a eventos,
// simplificar y reutilizar código.
//      Los delegados predicados, son exactamente iguales a los anteriores, pero con la peculiaridad de que solo pueden devolver datos de tipo
// boolean.
// https://docs.microsoft.com/en-us/dotnet/api/system.delegate?view=net-6.0

namespace _06_Delegados__predicados_y_lambdas
{
    internal class Program
    {
        delegate void Delegado_Mensaje(string s);

        static void Main(string[] args)
        {
            Delegado_Mensaje InstanciaDelegado = new Delegado_Mensaje(Mensaje.MostrarMensaje);
            InstanciaDelegado("Mensaje");

        }
    }


    internal class Mensaje
    {
        public static void MostrarMensaje(string s)
        {
            Console.WriteLine(s);
        }
    }
}