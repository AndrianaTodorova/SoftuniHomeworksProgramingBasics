using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Axe
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int dashes = 3 * n;
            int rightDashes = (2 * n) - 2;
            Console.WriteLine("{0}**{1}",
                new string ('-', dashes),
                new string ('-',rightDashes));

            int midSpaces = 1;
            for (int i = 1; i <= n - 1; i++)
            {
               
                Console.WriteLine("{0}*{1}*{2}",
                    new string ('-', dashes),
                    new string ('-', midSpaces),
                    new string ('-',rightDashes - 1));
                midSpaces+=1;
                rightDashes--;
            }
            midSpaces = n - 1;
            rightDashes = n - 1;
            for (int i = 0; i < n /2; i++)
            {
                Console.WriteLine("{0}*{1}*{2}",
                    new string('*', dashes),
                    new string('-', midSpaces),
                    new string('-', rightDashes ));
            }
            for (int i = 0; i < (n / 2) -1; i++)
            {
                Console.WriteLine("{0}*{1}*{2}",
                    new string('-', dashes),
                    new string('-', midSpaces),
                    new string('-', rightDashes));
                dashes--;
  
                midSpaces += 2;
                rightDashes--;

            }
            Console.WriteLine("{0}*{1}*{2}",
    new string('-', dashes),
    new string('*', midSpaces),
    new string('-', rightDashes));



            Console.WriteLine("{0}*{1}*{2}",
                    new string('-', dashes),
                    new string('*', midSpaces),
                    new string('-', rightDashes ));


        }
    }
}
