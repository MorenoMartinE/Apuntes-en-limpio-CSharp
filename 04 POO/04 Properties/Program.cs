using System;

//      El uso de las properties nos puede permitir simplificar la sintaxis a la hora de manipular las propiedades de los objetos
// sin necesidad de romper la encapsulación que es uno de los pilares fundamentales de la POO en C#. Su estructura es simple, consta
// de un bloque de código con un  método get y otro set (aunque puede solo tener uno de estos o ambos). 
// https://docs.microsoft.com/en-us/dotnet/csharp/properties


namespace _04_Properties
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //  Manipulacion normal con metodos get y set
            NumeroPositivo objeto = new NumeroPositivo();
            objeto.setNum(1000);
            Console.WriteLine(objeto.getNum());

            //  Manipulación con Propertiest 
            objeto.NUMERO = 1500;
            Console.WriteLine(objeto.NUMERO);



        }

        internal class NumeroPositivo
        {
            private int num = 0;

            public void setNum(int n)
            {
                if(n > 0)
                {
                this.num = n;
                }
                else
                {
                    Console.WriteLine("Fuera de rango.");
                }
            }

            public int getNum() => num;


            private int evaluaNumero(int n){
                if (n > 0)
                {
                    return n;
                }
                else
                {
                    return 0;
                }
            }

            public int NUMERO {
                get
                {
                    return this.num;
                }
                set
                {
                    this.num = evaluaNumero(value);
                }
            }



        }
    }
}
