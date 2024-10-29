using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programa_NumPrimo
{
    class NumPrimo
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingresa un número entero:");
            int numero = int.Parse(Console.ReadLine());

            bool esPrimo = true;

            if (numero <= 1)
            {
                esPrimo = false;
            }
            else
            {
                for (int i = 2; i < numero; i++)
                {
                    if (numero % i == 0)
                    {
                        esPrimo = false;
                        break;
                    }
                }
            }

            if (esPrimo)
            {
                Console.WriteLine("El número " + numero + " es primo.");
            }
            else
            {
                Console.WriteLine("El número " + numero + " no es primo.");
            }

            Console.ReadLine();
        }
    }
}
