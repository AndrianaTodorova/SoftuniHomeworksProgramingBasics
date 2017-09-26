using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Tiles
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = double.Parse(Console.ReadLine());
            var w = double.Parse(Console.ReadLine());
            var l = double.Parse(Console.ReadLine());
            var m = double.Parse(Console.ReadLine());
            var o = double.Parse(Console.ReadLine());

            var area = n * n;
            var benchArea = m * o;
            var tilesArea = w * l;
            var needTiles = Math.Round((area - benchArea) / tilesArea, 2);
            var needTime = Math.Round(needTiles * 0.2, 2);

            Console.WriteLine("{0:F2}", needTiles);
            Console.WriteLine("{0:F2}", needTime);
          
           
        }
    }
}
