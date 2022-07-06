using System;

//      Los tipos de datos en C# pueden dividirse en dos grandes grupos. Los tipos de datos por valor
// y los tipos de datos por referencia. Los primeros son aquellos que se almacenan de "manera directa"
// y los últimos son aquellos almacenados a través del uso de una dirección de memoria o referencia
// (es decir punteros).
//      En este primer apunte nos centramos en los tipos de datos por valor. Estos a su vez se dividen
// en tres tipos básicos. Primitivos, estructuras y enumerados.
//      Centrándonos en los primitivos, en C# nos referimos a datos enteros, reales, booleanos y caracteres.
// Los enteros son números enteros positivos y negativos, los reales números con coma flotante y los booleanos
// son un tipo de dato que admite dos valores verdadero o falso y los caracteres son caracteres (Algunos incluyen
// string aunque estos son una cadena de caracteres por lo cual no se considera un dato primitivo).
// https://elcamino.dev/tipos-de-datos-primitivos-en-c/
//      Los valores enteros se dividen a su vez en subcategorias dependiendo de su rango y por consecuencia
// del espacio en memoria que se reservara para almacenarlos (independientemente de si el valor almacenado
// efectivamente requiera de ese espacio).
// https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/integral-numeric-types
//      Una variable por definición es un espacio de memoria reservado donde se almacena un valor que podrá
// cambiar durante la ejecución del programa. (C# es un lenguaje fuertemente tipado y las variables al momento
// de ser declaradas deberan de indicar su tipo y ser declaradas antes de ser utilizadas).
// https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/language-specification/variables#:~:text=Variables%20represent%20storage%20locations.,always%20of%20the%20appropriate%20type.


namespace TiposDeDatos
{
    class Program
    {
        static void Main(String[] Args)
        {
            // Para dedclarar una variable hay que indicarle su tipo y darle un nombre. Para inicializarla hay que asignarle un valor valido.
            int num = 0;
            char car = 'a';
            bool boleano = true;


            Console.Write(num + "\n");
            Console.Write(car + "\n");
            Console.Write(boleano + "\n");
        }
    }
}