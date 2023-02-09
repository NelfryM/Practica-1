using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculoDeSalario
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // Variables
            double salarioBruto, salarioNeto, horasTrabajadas, salarioPorHora, salarioExtra;
            double afp = 0.0287, seguroSalud = 0.0304;

            // Pide al usuario el salario por hora y las horas trabajadas
            Console.Write("Introduce el salario por hora: ");
            salarioPorHora = double.Parse(Console.ReadLine());
            Console.Write("Introduce las horas trabajadas: ");
            horasTrabajadas = double.Parse(Console.ReadLine());

            // Calcula el salario bruto
            salarioBruto = salarioPorHora * horasTrabajadas;

            // Verifica si hay horas extras y las calcula
            if (horasTrabajadas > 44)
            {
                salarioExtra = (horasTrabajadas - 44) * (salarioPorHora * 0.3);
                salarioBruto += salarioExtra;
            }

            // Calcula el salario neto
            salarioNeto = salarioBruto - (salarioBruto * afp) - (salarioBruto * seguroSalud);

            // Muestra el resultado
            Console.WriteLine("Salario bruto: {0:0.00}", salarioBruto);
            Console.WriteLine("AFP ({0:0%}): {1:0.00}", afp, salarioBruto * afp);
            Console.WriteLine("Seguro de Salud ({0:0%}): {1:0.00}", seguroSalud, salarioBruto * seguroSalud);
            Console.WriteLine("Salario neto: {0:0.00}", salarioNeto);
            Console.ReadKey();



        }
    }
}
