using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.PipesInPool
{
    class Program
    {
        static void Main(string[] args)
        {
            var V = int.Parse(Console.ReadLine());
            var P1 = int.Parse(Console.ReadLine());
            var P2 = int.Parse(Console.ReadLine());
            double H = double.Parse(Console.ReadLine());

            var firstPipe =  P1 * H;
            var secondPipe = P2 * H;
            var resultInPercentages = firstPipe + secondPipe;



            if (resultInPercentages <= V)
            {
                
                Console.WriteLine("The pool is {0}% full. Pipe 1: {1}%. Pipe 2: {2}%.", 
                    Math.Truncate(resultInPercentages / V * 100),
                    Math.Truncate(P1 * H / resultInPercentages * 100),
                    Math.Truncate(P2 * H / resultInPercentages * 100));
            }

            else
            {
                Console.WriteLine("For {0} hours the pool overflows with {1}.0 liters. ", H, resultInPercentages - V);
            }
        }
    }
}
