using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.Cinema
{
    class Program
    {
        static void Main(string[] args)
        {
            string type = Console.ReadLine();
            double rows = double.Parse(Console.ReadLine());
            double columns = double.Parse(Console.ReadLine());

            double result = 0.0;

            if (type == "Premiere")
            {
                result = rows * columns * 12.00;
            }
            else if (type == "Normal")
            {
                result = rows * columns * 7.50;
            }
            else if (type == "Discount")
            {
                result = rows * columns * 5.00;
            }
            Console.WriteLine($"{result:f2} leva");
        }
    }
}
