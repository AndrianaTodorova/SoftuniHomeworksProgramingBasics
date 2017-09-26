using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Money
{
    class Program
    {
        static void Main(string[] args)
        {
            var bitcoins = double.Parse(Console.ReadLine());
            var joan = double.Parse(Console.ReadLine());
            var commision = double.Parse(Console.ReadLine());

           

            double result1 = bitcoins * 1168;
            double result2 = joan * 0.15;
            double result3 = result2 * 1.76;
            var result4 = (result1 + result2) / 1.95;
            var result5 = result4 * commision / 100;
            var result6 = Math.Round(result4 - result5, 2);

            Console.WriteLine(result6);


        }
    }
}
