using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraDeFisica
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Bienvenido a la Calculadora de Física");
            Console.WriteLine("Introduce dos de los siguientes tres valores: velocidad (v), tiempo (t), distancia (d)");
            Console.Write("Valor 1 (v, t, d): ");
            string value1 = Console.ReadLine();
            Console.Write("Valor 2 (v, t, d): ");
            string value2 = Console.ReadLine();

            Console.Write("Introduce el valor del primer dato: ");
            double input1 = double.Parse(Console.ReadLine());
            Console.Write("Introduce el valor del segundo dato: ");
            double input2 = double.Parse(Console.ReadLine());

            double result = 0;
            switch (value1 + value2)
            {
                case "vt":
                    result = input1 * input2;
                    Console.WriteLine("La distancia recorrida es: " + result + " m");
                    break;
                case "vd":
                    result = input2 / input1;
                    Console.WriteLine("El tiempo transcurrido es: " + result + " s");
                    break;
                case "td":
                    result = input2 / input1;
                    Console.WriteLine("La velocidad es: " + result + " m/s");
                    break;
            }


        }
    }
}
