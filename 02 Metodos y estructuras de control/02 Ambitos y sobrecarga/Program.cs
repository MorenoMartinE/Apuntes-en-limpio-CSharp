using System;

//      Los ámbitos definen el scope tanto de los métodos como de las variables. Al igual que en otros lenguajes
// los scops de las variables y los métodos están atados al bloque de código en el que estos son declarados.
// Es decir, las variables declaradas dentro de un bloque de código son variables locales salvo que se les indique
// lo contrario.





namespace _02_Ambitos_y_sobrecarga
{
    internal class Program
    {
        //      Para declarar variables de clase, que pueden ser accesadas desde cualquier método, debemos declararlas dentro
        // del bloque de código de la clase, pero fuera de cualquier método.
        int numClass = 2;


        static void Main(string[] args)
        {
            
            
        }

        void primerMetodo()
        {
            int 
             num1 = 5,
             num2 = 7;

            Console.WriteLine($"Las variables num1 y num2 fueron declaradas dentro de este metodo y pueden ser accesadas num1:{num1} num2:{num2} \n");
        }

        void segundoMetodo()
        {
            Console.WriteLine($"La variable numClass es accesible desde cualquier metodo, gracias a que tieme un ambito de clase numClass:{numClass}");
        }

        //      Por otra parte la sobrecarga de métodos se da cuando dos o más métodos poseen el mismo nombre. Pero esos métodos deben recibir
        // un tipo o numero de parámetros distintos. El compilador ejecutará el método que crea correspondiente dependiendo del caso de uso en
        // base a los parámetros que se reciben.
        static int suma(int operador1, int operador2) => operador1 + operador2;
        static double suma(double numero1, double numero2) => numero1 + numero2;

        //      C# También admite el uso de parámetros opcionales en las funciones. Para indicarle a C# que esta función puede o no recibir un
        // tercer parámetro a la hora de ser invocada, lo único que hay que hacer es darle a este un valor por defecto. De no ser proporcionado
        // a la hora de su invocación, este será el valor que tome la variable en la ejecución del bloque de código.
        static double suma(int nm1, double nm2, double nm3 = 0) => nm1 + nm2 + nm3;
    }

    
}
