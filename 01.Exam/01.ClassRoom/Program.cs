using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.ClassRoom
{
    class Program
    {
        static void Main(string[] args)
        {
            double h = double.Parse(Console.ReadLine());
            double w = double.Parse(Console.ReadLine());
           

            int rows = (int)(h / 1.2);
            int desks =(int) ((w - 1) / 0.7);
            double result = (rows * desks) - 3;
            Console.WriteLine(result);


        }
    }
}
