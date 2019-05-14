using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pto_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero, A, B, resultado, eleccion = 1;

            while (eleccion == 1)
            {
                Console.Write("1. Sumar\n");
                Console.Write("2. Restar\n");
                Console.Write("3. Multiplicar\n");
                Console.Write("4. Dividir\n");

                Console.Write("\n");

                Console.Write("Elija una opcion con su numero correspondiente\n");
                numero = Convert.ToInt32(Console.ReadLine());

                Console.Write("Digite el primer numero\n");
                A= Convert.ToInt32(Console.ReadLine());

                Console.Write("Digite el segundo numero\n");
                B = Convert.ToInt32(Console.ReadLine());

                switch (numero)
                {
                    case 1:
                        resultado = A + B;

                        Console.Write("El resultado es: ");
                        Console.Write(resultado);
                        break;

                    case 2:
                        resultado = A - B;

                        Console.Write("El resultado es: ");
                        Console.Write(resultado);
                        break;

                    case 3:
                        resultado = A * B;

                        Console.Write("El resultado es: ");
                        Console.Write(resultado);
                        break;

                    case 4:                      
                        if (B == 0)
                        {
                            Console.Write("No se puede dividir entre cero");
                        }
                        else
                        {
                            resultado = A / B;

                            Console.Write("El resultado es: ");
                            Console.Write(resultado);
                        }
                        break;
                }

                Console.Write("\n¿Desea realizar otra operacion? 1 para si, 0 para no\n");

                eleccion = Convert.ToInt32(Console.ReadLine());
            }

        }
    }
}
