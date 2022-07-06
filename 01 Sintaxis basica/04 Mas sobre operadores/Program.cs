using System;


namespace MasSobreOperadores
{
    class Program
    {
        static void Main(String[] args)
        {

            //      Comportamiento del operador de asignacion
            int
                num1,
                num2,
                num3,
                num4;

            num1 = num2 = num3 = num4 = 0;

            Console.Write(num4 + "\n");

            //      Asignacion implicita (Una vez se asigne en tiempo de ejecucion el tipo de la variable este no puede mutar).
            // https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/classes-and-structs/implicitly-typed-local-variables
            var num = 14;
            Console.Write(num + "\n");

            //      Conversión explícita o casting
            // https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/types/casting-and-type-conversions
            double com = 1.5;
            num = (int)com; // En este casting no se redondea, sino que se ignora la parte decimal.
            Console.Write(num + "\n");

            //      Conversión implícita, esta se da sin necesidad de un casting en tanto y en cuanto los tipos de dato sean compatibles.
            // https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/numeric-conversions
            long lg = num;
            Console.Write(lg + "\n");

            //      Type conversion. Haciendo uso del metodo Parse, podemos transfomar un tipo de variable en otra. El ingreso de datos por
            // terminal nos da como resultado una entrada de tipo String y la transformamos con int.Parse() en un dato de tipo entero para
            // poder ser utilizado.
            // https://docs.microsoft.com/en-us/dotnet/api/system.int64.parse?view=net-6.0

            Console.Write("\nIngresa el primer numero: ");
            num1 = int.Parse(Console.ReadLine());
            Console.Write("\nIngresa el segundo numero: ");
            num2 = int.Parse(Console.ReadLine());

            num3 = num1 + num2;

            Console.Write($"\nEl resultado de la suma de los dos valores es: {num3} \n");
        }
    }
}
