using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MergerFromFolder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Place this file next to the folder");
            Console.WriteLine("Write here the folder name: ");
            String mergeFolderName = Console.ReadLine();
            String[] toMerge = Directory.GetFiles(mergeFolderName);
            Console.WriteLine("Write here what would you like the result to be (example: result.txt, result.html, something.something):");
            String resultName = Console.ReadLine();
            StreamWriter sw = new StreamWriter(resultName);
            for (int i = 0; i < toMerge.Length; i++)
            {
                String lookedIn = File.ReadAllText(toMerge[i]);
                sw.Write(lookedIn+"\n");
                sw.WriteLine("That was from {0} ", toMerge[i]);

            }
            Console.WriteLine("Merging was successful, press any key.");
            Console.ReadKey();
            sw.Close();
        }
    }
}
