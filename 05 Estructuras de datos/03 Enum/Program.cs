using System;

//      Los enum o tipos enumerados son una estructura de datos a nuestra disposición para trabajar con valores
// fijos. Enum es una estructura que funciona a modo de colección de constantes. Como nota al pie, los tipo enumerados
// no son valores primitivos, son valores de tipo enum. Para ser utilizados deben de usarse castings y métodos según sea
// el caso.

namespace _03_Enum
{
    enum nums {cero=0, cien=100, mil=1000, menosCien=-100};


    internal class Program
    {
        static void Main(string[] args)
        {
            nums instancia = nums.mil;
            
            Console.WriteLine((int)instancia);



        }
    }
}