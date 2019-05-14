using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pto_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero;

            Console.Write("Ingrese un numero\n");

            numero = Convert.ToInt32(Console.ReadLine());

            Console.Write("Su valor absoluto es: ");
            Console.Write(Math.Abs(numero));
            Console.Write("\n");

            Console.Write("Su cuadrado es: ");
            Console.Write(Math.Pow(numero, 2));
            Console.Write("\n");

            if (numero< 0)
            {
                Console.Write("Los numeros negativos no tienen raiz real\n");
            }
            else
            {
                Console.Write("Su raiz cuadrada es: ");
                Console.Write(Math.Sqrt(numero));
                Console.Write("\n");
            }

            Console.Write("Su seno es: ");
            Console.Write(Math.Sin(numero));
            Console.Write("\n");

            Console.Write("Su coseno es: ");
            Console.Write(Math.Cos(numero));
            Console.Write("\n");

            if(numero.GetType() == Type.GetType("Single"))
            {
                Console.Write("Su parte entera es: ");
                int aux = (int)numero;
                Console.Write(aux);
                Console.Write("\n");
            }

            Console.Write("Ingrese el primer numero\n");
            int A = Convert.ToInt32(Console.ReadLine());

            Console.Write("Ingrese el segundo numero\n");
            int B = Convert.ToInt32(Console.ReadLine());

            Console.Write("El mayor es: ");
            Console.Write(Math.Max(A, B));

            Console.Write("\nEl menor es: ");
            Console.Write(Math.Min(A, B));

            Console.ReadKey();
        }
    }
}
