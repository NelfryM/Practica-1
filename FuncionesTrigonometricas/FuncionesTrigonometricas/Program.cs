using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuncionesTrigonometricas
{
    internal class Program
    {
        static void Main(string[] args)
        {

            double angulo_Grados;
            double angulo_Radianes;

            Console.WriteLine("Ingresa el ángulo en grados: ");
            angulo_Grados = Convert.ToDouble(Console.ReadLine());

            // Convertir el ángulo de grados a radianes
            angulo_Radianes = (Math.PI / 180) * angulo_Grados;

            Console.WriteLine("Sen(" + angulo_Grados + ") = " + Math.Sin(angulo_Radianes));
            Console.WriteLine("Cos(" + angulo_Grados + ") = " + Math.Cos(angulo_Radianes));
            Console.WriteLine("Tan(" + angulo_Grados + ") = " + Math.Tan(angulo_Radianes));
            Console.WriteLine("Sec(" + angulo_Grados + ") = " + (1 / Math.Cos(angulo_Radianes)));
            Console.WriteLine("Cosec(" + angulo_Grados + ") = " + (1 / Math.Sin(angulo_Radianes)));
            Console.WriteLine("Cotan(" + angulo_Grados + ") = " + (1 / Math.Tan(angulo_Radianes)));

            Console.ReadLine();

        }
    }
}
