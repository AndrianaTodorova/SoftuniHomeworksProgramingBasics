using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Vegetables
{
    class Program
    {
        static void Main(string[] args)
        {
            var kgvegetables = double.Parse(Console.ReadLine());
            var kgfroots = double.Parse(Console.ReadLine());
            var vegetablesprice = int.Parse(Console.ReadLine());
            var frootsprice = int.Parse(Console.ReadLine());

            double vegetablecost = kgvegetables * vegetablesprice;
            double frootcost = kgfroots * frootsprice;
            double result = (vegetablecost + frootcost) / 1.94;
            Console.WriteLine(result);
        }
    }
}
