using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Harvest
{
    class Program
    {
        static void Main(string[] args)
        {
            var areaOfTheVine = double.Parse(Console.ReadLine());
            var grapePerMeter = double.Parse(Console.ReadLine());
            var needLitersForWine = double.Parse(Console.ReadLine());
            var workers = double.Parse(Console.ReadLine());

            var litersLeft = Math.Abs(needLitersForWine - needLitersForWine);
            var litersPerPerson = litersLeft / workers;

            var allGrape = areaOfTheVine * grapePerMeter;
            var wine = 0.4 * allGrape / 2.5;

            if (wine > needLitersForWine)
            {
                Console.WriteLine("Good harvest this year! Total wine: {0} liters.",Math.Floor( wine));
                Console.WriteLine("{0} liters left -> {1} liters per person.",Math.Ceiling(litersLeft),Math.Ceiling(litersPerPerson));
            }
            else
            {
                Console.WriteLine("It will be a tough winter! More {0} liters wine needed.",Math.Floor(litersLeft));
            }
        }
    }
}
