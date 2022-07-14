using System;

namespace T05Ejercicio16
{
    class Program
    {
        static void Main()
        {
            int[] array = { 1, 5, 4, 3, 3, 2, 1 };
            //Utilizo el método Reverse de System.Linq
            //para invertir los valores de un array
            int[] arrayInverso = array.Reverse().ToArray();

            Console.WriteLine("Los elementos del array original por orden son: ");
            foreach (int i in array)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine();
            Console.WriteLine("Los elementos del array original invertidos son: ");
            foreach (int i in arrayInverso)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine();
        }
    }
}