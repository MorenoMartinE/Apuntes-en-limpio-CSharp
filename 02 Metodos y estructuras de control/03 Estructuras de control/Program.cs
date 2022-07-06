using System;

//      Los operadores de comparación admitidos por C# funcionan de la misma manera que en otros lenguajes
// estos son:
// == != < > <= >=
//      Los operadores en cortocircuito también
// && ||
//      La sintaxis de los condicionales y ciclos también son muy similares


namespace _01_Estructuras_de_control
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //      Evalúa una condición y dependiendo el resultado ejecuta un bloque u otro de código.
            if (true == true)
            {
                //  Sentencia verdadera
            }
            else
            {
                //  Sentencia falsa
            }


            //      Itera en tanto y en cuanto se cumpla la condición
            int a = 5;
            while(a > 0)
            {
                a--;
            }


            //      Igual que el caso anterior, con la salvedad de que se ejecuta al menos una vez antes de comprobar
            // si la condición se cumple o no.
            int b = -1;
            do
            {
                if(b == -1)
                {
                    b = 5;
                }
                else
                {
                    b--;
                }

            } while (b > 0);


            //      Evalúa una variable y de existir ejecuta el código del caso pertinente. De no existir coincidencia
            // ejecuta el caso por defecto.
            int c = 1;
            switch (c)
            {
                case 0:
                    // codigo de caso 0
                    break;
                case 1:
                    // codigo de caso 1
                    break;
                case 2:
                    // codigo de caso 2
                    break;
                default:
                    // codigo default
                    break;
            }

            //      Evalúa la condición e itera hasta que esta no se cumpla. Posee una variable index en su declaración.
            int d = 2;
            for(int i = 0; i < d; i++)
            {
                i++;
            }



        }
    }
}
