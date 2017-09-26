using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.SmartLilly
{
    class Program
    {
        static void Main(string[] args)
        {
            int age = int.Parse(Console.ReadLine());
            double laundry = double.Parse(Console.ReadLine());
            double toy = double.Parse(Console.ReadLine());

            for (int i = 0; i < age; i++)
            {
                if (i % 2 == 0)
                {
                    i += 10;
                }
                if (i % 2 != 0)
                {

                }
            }
        }
    }
}
