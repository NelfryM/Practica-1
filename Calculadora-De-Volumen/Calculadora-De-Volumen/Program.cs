using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraVolumen
{
    internal class Program
    {
        static void Main(string[] args)
        {


                double lado, volumen, radio, altura, basePiramide;


                Console.WriteLine("Selecciona una figura geométrica:");
                Console.WriteLine("1. Cubo");
                Console.WriteLine("2. Esfera");
                Console.WriteLine("3. Cono");
                Console.WriteLine("4. Pirámide");

                int opcion = Convert.ToInt32(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        Console.WriteLine("Ingresa el lado del cubo:");
                        lado = Convert.ToDouble(Console.ReadLine());
                        volumen = lado * lado * lado;
                        Console.WriteLine("El volumen del cubo es: " + volumen);
                        break;

                    case 2:

                        Console.WriteLine("Ingresa el radio de la esfera:");
                        radio = Convert.ToDouble(Console.ReadLine());
                        volumen = (4.0 / 3.0) * Math.PI * (radio * radio * radio);
                        Console.WriteLine("El volumen de la esfera es: " + volumen);
                        break;

                    case 3:

                        Console.WriteLine("Ingresa el radio y la altura del cono:");
                        Console.WriteLine("Radio: ");
                        radio = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Altura: ");
                        altura = Convert.ToDouble(Console.ReadLine());
                        volumen = Math.PI * (radio * radio) * (altura / 3);
                        Console.WriteLine("El volumen del cono es: " + volumen);
                        break;

                    case 4:

                        Console.WriteLine("Ingresa la base y la altura de la pirámide:");
                        Console.WriteLine("Base: ");
                        basePiramide = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Altura: ");
                        altura = Convert.ToDouble(Console.ReadLine());
                        volumen = (basePiramide * altura) / 3;
                        Console.WriteLine("El volumen de la pirámide es: " + volumen);
                        break;

                    default:
                        Console.WriteLine(" la opcion elegida no es valida");
                        break;
                }

                Console.ReadLine();
            }
        }
    }