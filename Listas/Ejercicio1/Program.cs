using System;
using System.Collections.Generic;

namespace Ejercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> fruta = new List<string>();
            CrearLista(fruta);
            MostrarLista(fruta);
            Console.WriteLine("\n");
            OrdenarLista(fruta);
        }
        public static void CrearLista(List <String> f)
        {
            f.Add("Manzana");
            f.Add("Naranja");
            f.Add("Platano");
            f.Add("Pera");
            f.Add("Limon");
        }
        public static void MostrarLista(List<String> f)
        {
            foreach (String x in f)
            {
                Console.WriteLine(x);
            }
        }
        public static void OrdenarLista(List<String> f)
        {
            f.Sort();
            MostrarLista(f);
        }
        public static void BorrarDeLaLista(List<String> f, string x)
        {
            f.Remove(x);
        }
        public static int ContarElementos(List<string> f)
        {
            return f.Count;
        }
    }
}
