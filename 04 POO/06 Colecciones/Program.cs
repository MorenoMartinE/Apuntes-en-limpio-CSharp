using System;
using System.Collections.Generic;


//      Las colecciones son clases genéricas que permiten almacenar elementos.
//      Las colecciones de tipo list son muy similares a los arreglos, pero nos permiten saltarnos algunas de las
// limitaciones que estos tienen a cambio de un mayor consumo de recursos del sistema. Nos permiten entre otras cosas almacenar elementos de forma
// dinámica en tiempo de ejecución, ordenar, buscar, eliminar, etc.
//      Las linked list o listas enlazadas son muy similares a las List por no decir idénticas, su mayor diferencia radica en su funcionamiento a nivel
// de consumo de memoria. Mientras que en una lista normal los elementos se almacenan en espacios de memoria adyacentes, en una LinkedList los datos pueden
// estar separados dentro de la memoria del sistema (Trabaja por nodos con dos punteros). Lo que mejora la eficiencia de una lista en términos del consumo
// de recursos. (Las colas y las pilas trabajan de manera similar, con la diferencia de que estas últimas no poseen dos punteros por nodo, solo uno. Lo que
// provoca que no puedan ser recorridas en ambas direcciones).
// https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic?view=net-6.0


namespace _05_Colecciones
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> nums = new List<int>();

            for (int i = 0; i < 10; i++)
            {
                nums.Add(i);
            }

            for(int i = 0; i < nums.Count; i++)
            {
                if(nums[i] % 2 != 0)
                {
                nums.RemoveAt(i);
                }
            }

            nums.Reverse();

            for(int i= 0; i < nums.Count; i++)
            {
                Console.WriteLine(nums[i]);
            }
        }
    }
}