using System;

//      Una interfaz es un conjunto de directrices que deben de cumplir las clases. Estas se componen de un conjunto de métodos
// declarados e incompletos que las clases que las implementen o hereden de ellas deberan de seguir.
//      Para declarar una interfaz, la sintaxis es muy similar a la de las clases. Pero en vez de utilizar la palabra reservada class
// debemos de dar uso a la palabra reservada interface. Por convención todas las interfaces deben de ser declaradas con una I mayúscula
// como primer carácter. No deben usarse modificadores de acceso dentro de las interfaces. Aunque si se les da el modificador public
// la interfaz funcionara sin problemas.



namespace _03_Interfaces
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IInterface objeto = new Objeto("objeto");
            Console.WriteLine(objeto.getNombre());

        }

        interface IInterface
        {
            string getNombre();
        }

        internal class Objeto : IInterface
        {
            private string name;

            public Objeto(string s)
            {
                this.name = s;
            }

            string IInterface.getNombre() => this.name; //  De no existir un método con el mismo nombre que cada uno de los métodos especificados dentro de
                                                        // la interface, C# nos indicaría que existe un error en el codigo y no nos permitirá compilar el programa
        }
    }
}