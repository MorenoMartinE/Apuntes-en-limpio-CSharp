using System;

//      A diferencia de otras estructuras de datos que se crean como un puntero en el stack y los datos
// se almacenan en memoria dentro del Heap, las estructuras se almacenan por completo en el stack al igual
// que los valores primitivos. Es decir, las instancias de strucco no son punteros, son un conjunto de variables.
//      A efectos prácticos lo que provoca es que al igualar dos estructuras y modificar cualquiera de estas,
// la otra no se verá modificada, debido a que son independientes.
//      Entre otras peculiaridades, las estructuras no permiten el uso de constructor por defecto, no permiten
// sobrecarga de constructores, no pueden heredar de clases ni otras estructuras (si de interfaces) y todas las
// estructuras son sealed.

namespace _02_Struct
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Estructura estructura1 = new Estructura(100);
            Estructura estructura2 = estructura1;

            estructura1.setNum(1000);

            Console.WriteLine(estructura1.getNum());
            Console.WriteLine(estructura2.getNum());
        }

        internal struct Estructura
        {
            private int num;

            public Estructura(int n)
            {
                this.num = n;
            }

            public void setNum(int n)
            {
                this.num = n;
            }

            public int getNum() => this.num;

        }





    }
}
