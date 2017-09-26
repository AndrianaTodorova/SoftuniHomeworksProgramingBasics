using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.EvenPowersOf2
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var num = 1;

            for (int i = 0; i <= n; i++)
            {
               
                if (i % 2 == 0)
                {
                    Console.WriteLine(num);
                    num = num * 4;
                }
               
            }
        }
    }
}
