using System;
using System.IO;

namespace ConsoleApp7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("// Enter an existing path:");
            string path = Console.ReadLine();
            FileRevision(path);
            Console.ReadKey();
        }

        static void FileRevision(string mainFolder)
        {
            if (string.IsNullOrEmpty(mainFolder))
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Empty folder");
                return;
            }

            foreach (string subFolder in Directory.GetDirectories(mainFolder))
            {
                Console.WriteLine("\n " + subFolder);
                foreach (string file in Directory.GetFiles(subFolder))
                {
                    Console.WriteLine(file.PadRight(15));
                }

                FileRevision(subFolder);
            }
        }
    }
}
