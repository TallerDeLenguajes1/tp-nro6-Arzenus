using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pto_4
{
    class Program
    {
        static void Main(string[] args)
        {
            //Los strings son un tipo de valor por referencia

            //Se incluyen las secuencias de escape (\\) para la barra diag inversa
            //(\u0066) para la letra f
            //(\n) para el salto de linea

            //cuando el @ esta antes de una cadena, esta ignora lo que normalmente seria una secuencia de escape

            string palabra = "Esto es un string";

            string nuevaPalabra = "Y este es otro string";

            string palabraCortada = palabra.Substring(0, 5);

            Console.Write(palabraCortada);

            Console.Write("\n");

            Console.Write(palabra.Length);

            Console.Write("\n");

            string union = palabra + nuevaPalabra;

            Console.Write(union);

            Console.Write("\n");

            int A = 3, B = 4;

            int suma = A + B;

            Console.Write("\n");

            string sumaEnString = suma.ToString();

            Console.Write("La suma de 3 y 4 es: ");
            Console.Write(sumaEnString);

            Console.Write("\n");

            foreach (char letra in union)
            {
                Console.Write(letra);
            }

            Console.Write("\n");

            if (union.Contains("este"))
            {
                Console.Write("La cadena contiene la palabra ESTE");
                Console.Write("\n");
            }
            Console.Write("\n");

            Console.Write(union.ToUpper());

            Console.Write("\n");

            Console.Write(union.ToLower());
            Console.Write("\n");

            string cadenaNueva = "Esta es una nueva cadena";

            Console.Write(String.Compare(union, cadenaNueva));
            Console.Write("\n");

            string diasDeSemana = "Lunes, Martes, Miercoles, Jueves, Viernes";

            string[] dias = diasDeSemana.Split(',');

            foreach (string dia in dias)
            {
                Console.Write(dia);
            }

            Console.ReadLine();
        }
    }
}
