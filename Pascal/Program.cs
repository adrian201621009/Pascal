using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Area

{
    public class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("\t\t Triangulo de Pascal en C#");
                       
            Console.Write("Ingresa el valor: ");
            int numero = int.Parse(Console.ReadLine());
            int x = numero * 2;
            for (int i = 0; i <= numero; ++i, x -= 2)
            {
                for (int s = 0; s <= x; ++s)
                {
                    Console.Write(" ");
                }
                for (int k = 0; k <= i; ++k)
                {
                    Console.Write(String.Format("{0,4:D}", formula(i, k)));
                    Console.WriteLine();
                }
            }
            Console.ReadKey();
        }

        public static int factorial(int numero)
        {
            int factorial = 1;
            for (int i = 1; i <= numero; ++i)
                factorial *= i;
            return factorial;
        }
        public static int formula(int numero, int posicion)
        {
            int combinacion;
            combinacion = factorial(numero) /
                (factorial(numero - posicion) * factorial(posicion));
            return combinacion;
        }

    }


 }
