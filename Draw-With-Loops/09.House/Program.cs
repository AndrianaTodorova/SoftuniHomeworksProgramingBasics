using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.House
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int stars = 0;
            if (n % 2 == 0)
            {
                stars = 2;
            }
            else
            {
                stars = 1;
            }

            for (int i = 0; i < (n + 1) / 2; i++)
            {
               
                Console.WriteLine("{0}{1}{0}",
                    new string('-', (n - stars) / 2),
                    new string ('*', stars));
                stars += 2;
                
              
            }
            for (int i = 0; i <= n / 2 -1; i++)
            {
                Console.WriteLine("|{0}|", new string ('*', n-2));
            }
        }
    }
}
