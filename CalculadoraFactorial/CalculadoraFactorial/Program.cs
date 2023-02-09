using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraFactorial
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numero, factorial = 1;

            Console.WriteLine("Ingresa un Numero para encontrar el factorial: \n");

            numero = Convert.ToInt32(Console.ReadLine());


            if (numero < 0)
            {
                Console.WriteLine("No Se Puede Calcular Este Numero");
                return;
            }

            for (int i = 1; i <= numero; i++)
            {
                factorial *= i;

            }

            Console.WriteLine("El factorial de " + numero + " es: " + factorial);

            Console.ReadLine();

        }
    }
}
