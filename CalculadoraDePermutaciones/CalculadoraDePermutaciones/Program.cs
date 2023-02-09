using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraDePermutaciones
{
    internal class Program
    {
        static void Main(string[] args)
        {

                Console.WriteLine("Cálculo de permutaciones");
                Console.WriteLine("1. Con repetición");
                Console.WriteLine("2. Sin repetición");
                Console.WriteLine("Selecciona una opción:");

                int option = int.Parse(Console.ReadLine());

                double result = 0;

                switch (option)
                {
                    case 1:
                        
                        Console.WriteLine("Ingrese el número de elementos:");
                        int elements = int.Parse(Console.ReadLine());
                        Console.WriteLine("Ingrese el tamaño de la permutación:");
                        int size = int.Parse(Console.ReadLine());
                        result = Math.Pow(elements, size);
                        break;

                    case 2:
                        

                        Console.WriteLine("Ingrese el número de elementos:");
                        int n = int.Parse(Console.ReadLine());
                        Console.WriteLine("Ingrese el tamaño de la permutación:");
                        int r = int.Parse(Console.ReadLine());
                        result = Factorial(n) / Factorial(n - r);
                        break;

                    default:
                        Console.WriteLine("Opción inválida");
                        break;
                }

                Console.WriteLine("Resultado: " + result);
            }

            static double Factorial(int num)
            {
                double result = 1;
                for (int i = 1; i <= num; i++)
                {
                    result *= i;
                }
                return result;
            }
        }
    }
