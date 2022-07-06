using System;


//      La herencia es la característica por la cual una clase padre le da acceso a sus atributos y métodos a sus elementos hijos.
// Los métodos y variables declarados con un modificador de acceso public o protected podrán ser utilizados en cualquiera de las clases hijas  
// (Como nota al pie, una variable declarada como protected solo será accesible dentro de la clase en la cual esta fue declarada y dentro de
// las clases que heredan de esta y no en otros scops). Aunque los privados también serán parte de esta como si fueran propios.
//      Para indicarle a una clase hijo que debe de llamar al constructor de la clase padre y no al constructor por defecto debemos de
// hacer uso del método base() tal y como se ve en el ejemplo.
//      NOTA: En este ejemplo las clases Padre e Hijo son exactamente iguales a efectos prácticos. Esto debido a que solo es un ejemplo
// de cómo funciona la herencia entre clases. No tiene ningún sentido que esto sea aplicado de la misma manera en un entorno de desarrollo
// real.
//      El principio de sustitución consiste en el reemplazo de un objeto por otro siempre teniendo en cuenta la jerarquía de herencias
// que estos tengan entre sí. En caso de hacer uso de la sustitución hay que tener en cuenta que el objeto creado no tendrá acceso a los
// métodos de su hijo, debido a que fácticamente es un objeto de la clase padre.
//      Si una clase hijo desea ignorar un método heredado por una de sus clases padres y reemplazarlo por otro, este deberá ser declarado
// con el uso de la palabra clave new (Esto es válido si previamente no existía un caso válido de sobrecarga). También es recomendable
// utilizar la palabra reservada virtual en el método dentro de la clase padre y override el método de la clase hijo, de esta manera
// le indicamos al compilador de C# que el método del hijo no debe simplemente ignorar y reemplazar al padre, sino que el método de la
// clase hijo es una modificación del método padre adaptado para funcionar de manera correcta en la clase hijo. El uso de las palabras
// reservadas virtual y override es especialmente útil al momento del uso de las sustituciones de clases, esto debido a que nos va a 
// permitir hacer uso de las clases de los hijos dentro de objetos de la clase padre en tanto y en cuanto estos sean sustitutos.
//      Esta capacidad es conocida como Polimorfismo. que podría definirse como la capacidad de una instancia de clase de actuar
// de diferentes maneras según sea el contexto actual en el que se encuentre.
//      Una clase abstracta es aquella que no está destinada a ser instanciada, sino que está destinada a englobar métodos y variables
// que se deben implementar en varias clases que están lo suficientemente distanciadas dentro de la planificación de la estructura de
// herencias como para heredar directamente desde la misma clase padre. Con que uno de los métodos de estas clases sean declarados
// pero no desarrollados, estas clases obligatoriamente deberán de ser abstractas.
//      Una clase sellada es aquella que no permite que otras clases hereden de ella. También se pueden sellar metodos para que las
// clases que hereden de otras no puedan sobreescribirlos. Estos dos comportamientos se consiguen con el uso de la palabra reservada
// sealed.




namespace _02_Herencia
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Hijo objetoHijo = new Hijo("Objeto");
            Console.WriteLine(objetoHijo.getName() + " " + objetoHijo.getId());

            Hijo objetoHijo1 = new Hijo("Objeto 01");
            Console.WriteLine(objetoHijo1.getName() + " " + objetoHijo1.getId());

            Padre objetoSustitucion = new Hijo("Objeto sustituto");
            Console.WriteLine(objetoSustitucion.getName() + " " + objetoSustitucion.getId());
            Console.WriteLine(objetoSustitucion.saludo());
        }




        internal abstract class Padre
        {
            private static int count = 0;
            private int id;
            protected string name;

            public Padre(string s)
            {
                this.name = s;
                this.id = count;
                count++;
            }

            public string getName() => this.name;
            public int getId() => this.id;

            public virtual string saludo() => "Saludo de objeto padre.";
           
            public abstract void setName(string s);
        }



        internal sealed class Hijo : Padre
        {
           public Hijo(string s) : base(s)
            {
                this.name = s + " Hijo";
            }

            public override string saludo() => "Saludo de objeto hijo.";

            public sealed override void setName(string s)
            {
                this.name = s;
            }
        }
    }
}
