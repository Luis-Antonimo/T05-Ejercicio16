using System;

namespace T05Ejercicio16
{
    class Program
    {
        static void Main()
        {
            int[] array = { 1, 2, 3, 4, 3, 2, 1 };
            //Invierto el array
            int[] arrayInverso = array.Reverse().ToArray();
            //Utilizo el método Equal para ver si son iguales
            bool capicua = array.SequenceEqual(arrayInverso);
            Console.WriteLine("El array {0} capicua.", capicua ? "es" : "no es");
        }
    }
}