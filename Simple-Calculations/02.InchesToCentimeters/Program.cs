using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.InchesToCentimeters
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Inches = ");
            double inch = double.Parse(Console.ReadLine());
            double cent = inch * 2.54;
            Console.Write("Centimeters = ");
            Console.WriteLine(cent);
        }
    }
}
