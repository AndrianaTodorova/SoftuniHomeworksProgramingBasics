using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.DrawFort
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var colsize = n / 2;
            var midSize = 2 * n - 2 * colsize - 4;

            Console.WriteLine("/{0}\\{1}/{0}\\",
                new string('^', colsize),
                new string ('_', midSize));

            for (int row = 1; row <= n - 3; row++)
            {
                Console.WriteLine("|{0}|",
                    new string (' ', 2 * n - 2));
            }
            Console.WriteLine("|{0}|",
                new string (' ', colsize + 1),
                new string ('_', midSize));
            Console.WriteLine("\\{0}/{1}\\{0}/",
                new string ('_', colsize),
                new string (' ', colsize));



            
        }
    }
}
