using System;
using System.IO;


//      Un destructor tiene como propósito liberar los recursos utilizados para una tarea que ya no es necesario continuar durante la ejecución
// de una aplicación. En este ejemplo cerramos el flujo de datos que creamos a un archivo externo.
//      Los destructores solo se utilizan el clases, cada clase solo puede tener un destructor, estos no se heredan ni se sobrecargan, no deben ser
// llamados, la invocación ocurre de manera automática ni cuentan con modificadores de acceso o parámetros.



namespace _04_Destructores
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ManejoDeDatos miArchivo = new ManejoDeDatos();
            miArchivo.mensaje();

        }
    }

    internal class ManejoDeDatos
    {
        private StreamReader archivo = null;

        private int count = 0;
        private string linea;

        public ManejoDeDatos()
        {
            archivo = new StreamReader(@"archivo.txt");

            while((linea = archivo.ReadLine()) != null)
            {
                Console.WriteLine(linea);
                count++;
            }
        }

        public void mensaje()
        {
            Console.WriteLine($"El archvio tiene {count} lineas.");
        }

        ~ManejoDeDatos()
        {
            archivo.Close();
        }
    }
}
