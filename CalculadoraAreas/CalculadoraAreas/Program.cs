using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraAreas
{
    internal class Program
    {
        static void Main(string[] args)
        {

                int num_opcion;
                double area = 0;
                double lado;
                double baseTriangulo;
                double radio;
                double alturaTriangulo;
                double apotema;


                Console.WriteLine("Calculadora de areas ");
                Console.WriteLine("1. Cuadrado");
                Console.WriteLine("2. Círculo");
                Console.WriteLine("3. Triángulo");
                Console.WriteLine("4. Pentágono");
                Console.WriteLine("5. Hexagono");
                Console.WriteLine(" Selecciona la figura al cual calcular el área");

                num_opcion = Convert.ToInt32(Console.ReadLine());

                switch (num_opcion)

                {
                    case 1:

                        Console.WriteLine("Introduzca el lado del cuadrado:");
                        lado = Convert.ToDouble(Console.ReadLine());
                        area = lado * lado;
                        break;

                    case 2:

                        Console.WriteLine("Introduzca el radio del círculo:");
                        radio = Convert.ToDouble(Console.ReadLine());
                        area = Math.PI * radio * radio;
                        break;

                    case 3:

                        Console.WriteLine("Introduzca la base del triángulo:");
                        baseTriangulo = Convert.ToDouble(Console.ReadLine());

                        Console.WriteLine("Introduzca la altura del triángulo:");
                        alturaTriangulo = Convert.ToDouble(Console.ReadLine());
                        area = (baseTriangulo * alturaTriangulo) / 2;
                        break;

                    case 4:

                        Console.WriteLine("Introduzca el apotema del pentágono:");
                        apotema = Convert.ToDouble(Console.ReadLine());

                        Console.WriteLine("Introduzca la longitud del lado del pentágono:");
                        lado = Convert.ToDouble(Console.ReadLine());
                        area = (5 * lado * apotema) / 2;
                        break;

                    case 5:

                        Console.WriteLine("Introduzca la apotema del hexágono:");
                        apotema = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Introduzca la longitud del lado del hexágono:");
                        lado = Convert.ToDouble(Console.ReadLine());
                        area = (6 * lado * apotema) / 2;
                        break;

                    default:

                        Console.WriteLine("Opción elegida no existe.");
                        break;


                }
                Console.WriteLine("El área de la figura seleccionada es: " + area);

                Console.ReadLine();
            }


        }

    }