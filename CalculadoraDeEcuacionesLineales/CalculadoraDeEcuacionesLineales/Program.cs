using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraDeEcuacionesLineales
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Resolución de Ecuaciones Lineales de Primer Grado");
            Console.WriteLine("Este programa resuelve ecuaciones de la forma ax + b = 0");

            Console.WriteLine("\nIngrese el valor de a:");
            double a = double.Parse(Console.ReadLine());

            Console.WriteLine("\nIngrese el valor de b:");
            double b = double.Parse(Console.ReadLine());

            double x = -b / a;

            Console.WriteLine("\nEl resultado es x = " + x);

            Console.WriteLine("\nPresione cualquier tecla para salir");
            Console.ReadKey();


        }
    }
}