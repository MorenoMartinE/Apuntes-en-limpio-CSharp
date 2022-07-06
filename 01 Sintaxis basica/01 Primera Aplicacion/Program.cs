using System;


//      Los espacios tienen por objetivo almacenar las clases creadas dentro de una aplicación,
// las clases dentro de un namespace no entraran en conflicto con clases en otros namespaces.
// Todas las clases preexistentes tanto del lenguaje como de librerias externas deberan ser
// agregadas en la cabecera del proyecto usando la palabra reservada using. Por otra parte
// para declarar una clase dentro de un namespace deberemos de usar la palabra reservada
// class e iniciar su nombre en mayúscula.


namespace PrimerApp
{
    class Program
    {
        static void Main(String[] Args)
        {
            Console.Write("Hola Mundo");
        }
    }
}