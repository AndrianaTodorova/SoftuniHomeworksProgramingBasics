using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace o2.Divide
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

           
            double p1 = 0;
            double p2 = 0;
            double p3 = 0;

            for (int i = 0; i < n; i++)
            {
                double num = double.Parse(Console.ReadLine());
                

                if (num % 2 == 0)
                {
                    ++p1;
                }
                if (num % 3 == 0)
                {
                    ++p2;
                }
                 if (num % 4 == 0)
                {
                    ++p3;
                }

            }
            Console.WriteLine("{0:0.00}%", 100 * p1 / n);
            Console.WriteLine("{0:0.00}%", 100 * p2 / n);
            Console.WriteLine("{0:0.00}%", 100 * p3 / n);
        }
    }
}
