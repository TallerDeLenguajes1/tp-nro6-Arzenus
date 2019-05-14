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
                for (cifras = ContarCifras(numero); cifras > 0; cifras--)
                {
                    resto = numero % 10;

                    aux =(int)(resto * Math.Pow(10, cifras - 1));

                    valorInvertido = valorInvertido + aux;

                    numero = numero / 10;
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
    }
}