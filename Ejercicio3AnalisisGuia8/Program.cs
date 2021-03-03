using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio3AnalisisGuia8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Black;
            Console.BackgroundColor = ConsoleColor.White;
            Console.Clear();

            Double op, numerador, denominador, division, num, cubo, peso, altura, IMC;

            

            do
            {
                Console.Title = "Programa que muestra menú de calculo.";
                Console.WriteLine("\n\tOPERACIONES MATEMÁTICAS:");
                Console.WriteLine("\n\t1. Dividir");
                Console.WriteLine("\n\t2. Obtener cubo");
                Console.WriteLine("\n\t3. Cálculo de IMC (Índice de Masa Corporal)");
                Console.WriteLine("\n\t4. Salir del programa");
                Console.WriteLine("\n ");
                Console.Write("Digite su opción: ");
                op = Double.Parse(Console.ReadLine());



                switch (op)
                {
                    case 1:
                        Console.Clear();
                        Console.WriteLine("Usted ha seleccionado la opción: Dividir.");
                        Console.WriteLine("Ingrese el numerador de la división: ");
                        numerador = Double.Parse(Console.ReadLine());
                        Console.WriteLine("Ingrese el denominador de la división: ");
                        denominador = Double.Parse(Console.ReadLine());
                        division = (numerador / denominador);
                        Console.WriteLine("El resultado de la división es: " + division);
                        break;

                    case 2:
                        Console.Clear();
                        Console.WriteLine("Usted ha seleccionado la opción: Obtener cubo.");
                        Console.WriteLine("Ingrese el número del que desea conocer el cubo: ");
                        num = Double.Parse(Console.ReadLine());
                        cubo = (Math.Pow(num, 3));
                        Console.WriteLine("El cubo de " + num + " es: " + cubo);
                        break;

                    case 3:
                        Console.Clear();
                        Console.WriteLine("Usted ha seleccionado la opción: Cálculo de IMC (Índice de Masa Corporal).");
                        Console.WriteLine("Ingrese su peso en kilogramos: ");
                        peso = Double.Parse(Console.ReadLine());
                        Console.WriteLine("Ingrese su altura en metros: ");
                        altura = Double.Parse(Console.ReadLine());
                        IMC = peso / (Math.Pow(altura, 2));
                        Console.Write("Su índice de masa corporal es de: " + (IMC.ToString("#.##")));
                        break;
                        
                    case 4:
                        Console.Clear();
                        Console.WriteLine("Saliendo del programa...");
                        Environment.Exit(0);
                        break;

                    default:
                        Console.Clear();
                        Console.WriteLine("Opción no definida.");
                        break;
                }

            } while (op >= 1 && op <= 4);

            {
                Console.WriteLine("La opción debe de estar dentro del menú.");
            }

            Console.ReadKey();

        }
    }
}
