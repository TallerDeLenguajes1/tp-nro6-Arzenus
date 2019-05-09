using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_6_Tarulli
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero, valorInvertido = 0, resto = 0, cifras = 0, aux = 0;

            Console.Write("Ingrese un numero\n");
            
            numero = Convert.ToInt32(Console.ReadLine());


            if(numero > 9)
            {
                cifras = ContarCifras(numero);

                aux = cifras;

                for (int i = 0; i< cifras; i++)
                {
                    resto = Cifra(numero);

                    valorInvertido = valorInvertido + (resto* (10 ^ (i-1)));

                    numero = numero / 10;

                    aux = aux - 1;
                }
                
                Console.Write("El numero invertido es : ");
                Console.Write(valorInvertido);

                Console.ReadKey();
            }
            else
            {
                Console.Write("El numero es menor que 9, no se lo puede invertir");

                Console.ReadKey();
            }
        }

        static public int ContarCifras(int numero)
        {
            int cifras = 0;

            while (numero != 0)
            {
                cifras = cifras + 1;

                numero = numero / 10;
            }

            return cifras;
        }

        static public int Cifra (int numero)
        {
            int resto = 0;

            while (numero != 0)
            {
                resto = numero % 10;

                numero = numero / 10;
            }
            return resto;
        }

    }




}