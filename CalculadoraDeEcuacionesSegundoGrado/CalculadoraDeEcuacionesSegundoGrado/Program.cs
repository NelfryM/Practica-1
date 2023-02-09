using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraDeEcuacionesSegundoGrado
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Introduce los valores de a, b y c para la ecuación de segundo grado: ax^2 + bx + c = 0");
            Console.Write("a: ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("b: ");
            double b = double.Parse(Console.ReadLine());
            Console.Write("c: ");
            double c = double.Parse(Console.ReadLine());

            double x1, x2;

            double discriminante = b * b - 4 * a * c;
            if (discriminante > 0)
            {
                x1 = (-b + Math.Sqrt(discriminante)) / (2 * a);
                x2 = (-b - Math.Sqrt(discriminante)) / (2 * a);
                Console.WriteLine("Las soluciones de la ecuación son x1 = {0} y x2 = {1}", x1, x2);
            }
            else if (discriminante == 0)
            {
                x1 = (-b) / (2 * a);
                Console.WriteLine("La solución única de la ecuación es x = {0}", x1);
            }
            else
            {
                Console.WriteLine("La ecuación no tiene soluciones reales");

            }
        }
    }
}