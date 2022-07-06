using System;


//      Una clase es una estructura cuya función es servir de "molde" de creación para un objeto o instancia de esta misma. Si nos referimos
// a estructura como un conjunto de propiedades y métodos predefinidos que los objetos que deriven de esta deben tener. No existen muchas
// diferencias en comparación con otros lenguajes de programación orientados a objetos. 
// https://docs.microsoft.com/es-es/dotnet/csharp/fundamentals/tutorials/classes
// https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/classes-and-structs/access-modifiers // Estos no son exclusivos de las clases.

//      La palabra reservada this, en el caso de C# a diferencia de otros lenguajes no hace referencia al contexto en base al scop, sino que hace
// referencia únicamente al contexto dentro del actual objeto de clase (o clase en si misma si esta es estática).
// https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/this

//      Si una variable o un metodo dentro de una clase es declarada con la palabra static, esto provocará que no se instancie al crear un nuevo objeto. Dando
// como resultado que la variable pertenezca directamente a la clase y sea compartida por todas las instancias de la clase.

//      Las clases anónimas funcionan de manera muy similar a como funcionan en Js los objetos literales. Las instancias de clases anónimas se considerarán
// parte de la misma clase si los campos que poseen son del mismo tipo, poseen el mismo nombre identificador y están en el mismo orden.
// https://docs.microsoft.com/es-es/dotnet/csharp/fundamentals/types/anonymous-types

namespace _01_Clases_e_instancias
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Clase instancia = new Clase("objeto");
            Console.WriteLine($"El nombre de la instancia del objeto Clase con id {instancia.mostrarId()} es {instancia.mostrarNombre()}");

            Clase instancia1 = new Clase("objeto1");
            Console.WriteLine($"El nombre de la instancia del objeto Clase con id {instancia1.mostrarId()} es {instancia1.mostrarNombre()}");

            Clase instancia2 = new Clase("objeto2");
            Console.WriteLine($"El nombre de la instancia del objeto Clase con id {instancia2.mostrarId()} es {instancia2.mostrarNombre()}");


            var claseAnonima = new { Nombre = "Clase anonima 01", Numero = 1};
            Console.WriteLine($"La clase anonima se llama {claseAnonima.Nombre} y su numero es {claseAnonima.Numero}");
        }
    }

    internal class Clase
    {
        //  Propiedades
        private static int count = 0;
        private string nombre;
        private readonly int id;
        

        public Clase(string s)
        {
            this.nombre = s;
            this.id = count;
            count++;
        }
        
        public int mostrarId() => id;

        public string mostrarNombre() => nombre;

        public void cambiarNombre(string s)
        {
            this.nombre = s;
        }
    }
}
