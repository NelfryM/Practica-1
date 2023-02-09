using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraDePromedio
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("...................Bienvenido al Calculador de Promedios de nota...................");

            Console.Write("Introduce la primera nota: ");
            int nota1 = int.Parse(Console.ReadLine());

            Console.Write("Introduce la segunda nota: ");
            int nota2 = int.Parse(Console.ReadLine());

            Console.Write("Introduce la tercera nota: ");
            int nota3 = int.Parse(Console.ReadLine());

            Console.Write("Introduce la cuarta nota: ");
            int nota4 = int.Parse(Console.ReadLine());

            int total = nota1 + nota2 + nota3 + nota4;
            double promedio = (double)total / 4;
            Console.WriteLine("El promedio es: " + promedio);

            if (promedio >= 90)
                Console.WriteLine("El literal correspondiente es A");

            else if (promedio >= 80)
                Console.WriteLine("El literal correspondiente es B");

            else if (promedio >= 70)
                Console.WriteLine("El literal correspondiente es C");

            else if (promedio >= 60)
                Console.WriteLine("El literal correspondiente es D");

            else
                Console.WriteLine("El literal correspondiente es F");

            Console.WriteLine("Presione cualquier tecla para salir");
            Console.ReadKey();


        }
    }
}
