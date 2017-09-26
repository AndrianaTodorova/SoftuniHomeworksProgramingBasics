using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.ChristmasTree
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i <= n; i++)
            {
               // Console.WriteLine("{0}{1} | {1}{0}",  new string(' ', n - i),new string('*', i));
               //ВАЖНООООО!!!!

                Console.Write(new string (' ', n - i));
                Console.Write(new string('*', i));
                Console.Write(" ");
                Console.Write("|");
                Console.Write(" ");
                Console.Write(new string('*', i));
                Console.Write(new string(' ', n - i));
                Console.WriteLine();
            }
        }
    }
}
