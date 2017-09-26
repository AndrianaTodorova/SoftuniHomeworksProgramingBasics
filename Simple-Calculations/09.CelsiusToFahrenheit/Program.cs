using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.CelsiusToFahrenheit
{
    class Program
    {
        static void Main(string[] args)
        {
            double cels = double.Parse(Console.ReadLine());
            double fahr = cels * 1.8 + 32;
            Console.WriteLine(Math.Round(fahr, 2));
        }
    }
}
