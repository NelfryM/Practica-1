using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConvertidorDeTemperatura
{
    internal class Program
    {
        static void Main(string[] args)
        {

                double temperatura;
                int opcion;

                Console.WriteLine("Bienvenido al Conversor de Temperaturas");
                Console.WriteLine("Elija la opción que desea realizar:");
                Console.WriteLine("1. Celsius a Kelvin");
                Console.WriteLine("2. Celsius a Fahrenheit");
                Console.WriteLine("3. Kelvin a Celsius");
                Console.WriteLine("4. Kelvin a Fahrenheit");
                Console.WriteLine("5. Fahrenheit a Celsius");
                Console.WriteLine("6. Fahrenheit a Kelvin");
                Console.Write("Introduzca el número de la opción deseada: ");

                opcion = int.Parse(Console.ReadLine());
                Console.Write("Introduzca la temperatura: ");
                temperatura = double.Parse(Console.ReadLine());

                switch (opcion)
                {
                    case 1:

                        Console.WriteLine("La temperatura en Kelvin es: " + (temperatura + 273.15));
                        break;

                    case 2:

                        Console.WriteLine("La temperatura en Fahrenheit es: " + (temperatura * 9 / 5 + 32));
                        break;

                    case 3:

                        Console.WriteLine("La temperatura en Celsius es: " + (temperatura - 273.15));
                        break;

                    case 4:

                        Console.WriteLine("La temperatura en Fahrenheit es: " + (temperatura * 9 / 5 - 459.67));
                        break;

                    case 5:

                        Console.WriteLine("La temperatura en Celsius es: " + (temperatura - 32) * 5 / 9);
                        break;

                    case 6:

                        Console.WriteLine("La temperatura en Kelvin es: " + (temperatura + 459.67) * 5 / 9);
                        break;

                    default:

                        Console.WriteLine("Opción no válida");
                        break;
                }

                Console.WriteLine("Presione cualquier tecla para salir");
                Console.ReadKey();
            }
        }
    }