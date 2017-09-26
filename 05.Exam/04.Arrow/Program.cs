using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Arrow
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int outerDots = (n - 1) / 2;
            int innerDots = n - 2;

            Console.WriteLine("{0}{1}{0}",
                new string ('.', outerDots),
                new string ('#', n));
            for (int i = 0; i < n-2; i++)
            {
                Console.WriteLine("{0}#{1}#{0}",
                    new string ('.', outerDots),
                    new string ('.', innerDots));
            }
            Console.WriteLine("{0}{1}{0}",
                new string ('#', n-2),
                new string ('.', innerDots));
            outerDots = 1;
            innerDots = 2 * n - 5;
            for (int i = 0; i < n - 2; i++)
            {
                Console.WriteLine("{0}#{1}#{0}",
                   new string ('.', outerDots),
                   new string ('.', innerDots));
                outerDots++;
                innerDots -= 2;
            }
            Console.WriteLine("{0}#{0}",
                new string ('.', outerDots));
        }
    }
}
