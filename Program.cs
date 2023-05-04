using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp12
{
    /// <summary>
    /// Коллекция женских имен
    /// </summary>
    class Program
    {
        static void Output(List<string>ints)
        {
            foreach (string element in ints)
            {
                Console.Write($"{element}\t");
            }
        }
        static void Main(string[] args)
        {
            var name = new List<string>(){"Anna,", "Ira,", "Nona"};
            Output(name);
           
            Console.ReadLine();
        }
    }
}
