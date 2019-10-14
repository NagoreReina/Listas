using System;
using System.Collections.Generic;

namespace Ejercicio4
{
    class Program
    {
        public static List<CantanteFamoso> ListaCantantesFamosos = new List<CantanteFamoso>();
        static void Main(string[] args)
        {
            AnadirCantante("Pepito", "Grillo");
            AnadirCantante("Mariano", "Rajoy");
            Console.WriteLine("Lista de cantantes actual: ");
            MostrarDatos();
            bool closeProrgram = false;
            do
            {
                Console.WriteLine("¿Quieres introducir otro cantante? (Yes/No)");
                string respuesta = Console.ReadLine().ToUpper();
                switch (respuesta)
                {
                    case "YES":
                        Console.WriteLine("Introduce el cantante");
                        string textoNombre = Console.ReadLine();
                        Console.WriteLine("Introduce el disco");
                        string textoDisco = Console.ReadLine();
                        AnadirCantante(textoNombre, textoDisco);
                        MostrarDatos();
                        break;
                    case "NO":
                        closeProrgram = true;
                        break;
                    default:
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("ERROR: NO HAS INTRODUCIDO UN VALOR CORRECTO (VALIDOS SOLO 'YES' O 'NO')");
                        Console.ForegroundColor = ConsoleColor.White;
                        break;
                }
            } while (!closeProrgram);
        }
        public static void AnadirCantante(string nombre, string disco)
        {
            ListaCantantesFamosos.Add(new CantanteFamoso(nombre, disco));
        }
        public static void MostrarDatos()
        {
            foreach (CantanteFamoso x in ListaCantantesFamosos)
            {
                Console.WriteLine($"Cantante: {x.Nombre} || Disco: {x.DiscoMasFamoso}");
            }
        }
    }
}
