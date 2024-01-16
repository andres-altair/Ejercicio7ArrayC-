using Ejercicio7ArrayC;
using System.Collections;
using System.Security.Claims;

namespace Ejercicio7ArrayC 
{ 
    class Program
    {
        public static void Main(string[] args)
        {
          
            int[] numero = { 10, 45, 60, 6, 7, 3, 2, 10 };
            int longuitud = numero.Length;
            Console.WriteLine(longuitud);
            Console.WriteLine(numero[1]);
            Console.WriteLine(numero[7]);
            Console.WriteLine(numero[8]);
            Array.Sort(numero);
            numero[8] = 100;
            Array.Reverse(numero);


            int[] numeros2 = { 45, 56, 2, -1, 98, 34 };
            int longutud2 = numeros2.Length;
            Console.WriteLine(numeros2[5]);
            Console.WriteLine(numeros2[1]);
            Console.WriteLine(numeros2[6]);
        }
    }
}