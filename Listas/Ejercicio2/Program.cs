using System;
using System.Collections.Generic;

namespace Ejercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> enteros = new List<int>();
            List<double> decimales = new List<double>();
            double num = 0;
            do
            {
                Console.WriteLine("Introduce un valor");
                string textoUsuario = Console.ReadLine();
                if (double.TryParse(textoUsuario, out num))
                {
                    if (num >= 0)
                    {
                        if (textoUsuario.Contains("."))
                        {
                            decimales.Add(num);
                        }
                        else
                        {
                            enteros.Add(Convert.ToInt32(num));
                        }
                    }
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("ERROR: NO HAS INTRODUCIDO UN NUMERO");
                    Console.ForegroundColor = ConsoleColor.White;
                }

            } while (num >= 0);
            Console.WriteLine("Enteros:");
            int sumaEnteros = 0;
            double sumaDecimales = 0;
            foreach (int x in enteros)
            {
                Console.Write($"{x}, ");
                sumaEnteros += x;
            }
            Console.WriteLine("");
            Console.WriteLine("Decimales:");
            foreach (double x in decimales)
            {
                Console.Write($"{x}, ");
                sumaDecimales += x;
            }
            Console.WriteLine("");
            Console.WriteLine($"La suma de todos los enteros es: {sumaEnteros}");
            Console.WriteLine($"La media de todos los numeros es: {(sumaEnteros+sumaDecimales)/(enteros.Count+decimales.Count)}");


        }
    }
}
