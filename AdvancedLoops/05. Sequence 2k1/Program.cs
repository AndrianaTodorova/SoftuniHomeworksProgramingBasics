using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Sequence_2k1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var num = 1;

            for (int i = 0; num <= n; i++)
            {
                Console.WriteLine(num);
                num = num * 2 + 1;
            }
        
        }
    }
}
