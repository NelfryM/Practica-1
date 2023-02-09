using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesglosadorDeBilletes
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // Define las denominaciones de los billetes
            int[] denominations = { 2000, 1000, 500, 200, 100, 50, 25, 10, 5, 1 };

            // Pide al usuario que introduzca un número
            Console.Write("Introduce un número: ");
            int num = int.Parse(Console.ReadLine());

            // Desglosa el número en billetes
            Console.WriteLine("Desglose de billetes: ");
            foreach (int denomination in denominations)
            {
                int number_of_notes = num / denomination;
                if (number_of_notes > 0)
                {
                    Console.WriteLine("{0} billete de {1}", number_of_notes, denomination);
                    num = num % denomination;
                }
            }
            Console.ReadKey();

        }
    }
}
