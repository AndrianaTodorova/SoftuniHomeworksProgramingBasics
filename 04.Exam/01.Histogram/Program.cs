using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Histogram
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double p1 = 0;
            double p2 = 0;
            double p3 = 0;
            double p4 = 0;
            double p5 = 0;
            double p = 0;

            for (int i = 0; i < n; i++)
            {
                int num = int.Parse(Console.ReadLine());
                ++p;
               
                if (num >= 800)
                {
                    ++p5;
                }
                else if (num >= 600)
                {
                    ++p4;
                }
                else if (num >= 400)
                {
                    ++p3;
                }
                else if (num >= 200)
                {
                    ++p2;
                }
                else 
                {
                    ++p1;
                }

            }
            Console.WriteLine("{0:0.00}%", 100 * p1/ p);
            Console.WriteLine("{0:0.00}%", 100 * p2/ p);
            Console.WriteLine("{0:0.00}%", 100 * p3/ p);
            Console.WriteLine("{0:0.00}%", 100 * p4/ p);
            Console.WriteLine("{0:0.00}%", 100 * p5/ p);
        }
    }
}
