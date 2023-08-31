using System;
using System.IO;

namespace ConsoleApp7
{
    internal class Program
    {
        static void Main(string[] args) 
        {
            Console.WriteLine("// Ingresa una ruta existente:");
            string ruta = Console.ReadLine();
            RevisionArchivos(ruta);
            Console.ReadKey();
        }

        static void RevisionArchivos(string carpetaPrincipal)
        {
            if (string.IsNullOrEmpty(carpetaPrincipal))
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Carpeta vacía");
                return;
            }

            foreach (string carpeta in Directory.GetDirectories(carpetaPrincipal))
            {
                Console.WriteLine("\n " + carpeta);
                foreach (string archivo in Directory.GetFiles(carpeta))
                {
                    Console.WriteLine(archivo.PadRight(15));
                }

                RevisionArchivos(carpeta);
            }
        }
    }
}
