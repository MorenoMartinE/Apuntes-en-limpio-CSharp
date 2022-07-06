using System;


//      El propósito de las clases genéricas es el de almacenar y utilizar distintas instancias de otras clases. Al igual que lo
// podemos hacer valiéndonos de las propiedades de la herencia, pero con algunas ventajas y un código más simplificado.
//      Para declarar una clase como genérica, luego del nombre de la clase dentro de la declaración debemos de agregar un
// <> con una letra. Por convención en C# se utiliza una T.


namespace _05_Clases_genericas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Generica<String> archivos = new Generica<String>(4);

            archivos.agregar("Uno");
            archivos.agregar("Dos");
            archivos.agregar("Tres");
            archivos.agregar("Cuatro");

            String str = archivos.gerElemento(2);

            Console.WriteLine(str);
        }
    }

    internal class Generica <T>
    {
        private T[] datosElemento;
        private static int i = 0;

        public Generica(int z)
        {
            datosElemento = new T[z];
        }

        public T gerElemento(int i)
        {
            return datosElemento[i];
        }

        public void agregar(T obj)
        {
            datosElemento[i] = obj;
            i++;
        }
    }
}


