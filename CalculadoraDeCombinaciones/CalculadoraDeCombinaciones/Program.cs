using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraDeCombinaciones
{
    internal class Program
    {
        static void Main(string[] args)
        {

                Console.WriteLine("Ingrese el número de elementos (n):");
                int n = int.Parse(Console.ReadLine());

                Console.WriteLine("Ingrese el número de elementos a elegir (k):");
                int k = int.Parse(Console.ReadLine());

                Console.WriteLine("¿Permitir repetición de elementos? (s/n):");
                string repeticion = Console.ReadLine();

                int resultado;

                if (repeticion == "s")
                {
                    resultado = CombinacionConRepeticion(n, k);
                    Console.WriteLine("El número de combinaciones con repetición es: " + resultado);
                }
                else
                {
                    resultado = CombinacionSinRepeticion(n, k);
                    Console.WriteLine("El número de combinaciones sin repetición es: " + resultado);
                }
            }

            static int CombinacionConRepeticion(int n, int k)
            {
                return (int)Math.Pow(n, k);
            }

            static int CombinacionSinRepeticion(int n, int k)
            {
                return Factorial(n) / (Factorial(k) * Factorial(n - k));
            }

            static int Factorial(int n)
            {
                int resultado = 1;
                for (int i = 1; i <= n; i++)
                {
                    resultado *= i;
                }
                return resultado;
         }
    }
}
