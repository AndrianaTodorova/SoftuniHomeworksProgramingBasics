using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13.AreaOfFigures
{
    class Program
    {
        static void Main(string[] args)
        {
            string typeFigure = Console.ReadLine();
            double firstSide = double.Parse(Console.ReadLine());
           


            if (typeFigure == "square")
            {
                Console.WriteLine(Math.Round(firstSide * firstSide, 3));
            }
            else if (typeFigure == "circle")
            {
                Console.WriteLine(Math.Round(Math.PI * firstSide * firstSide, 3));
            }

            double secondSide = double.Parse(Console.ReadLine());
            if (typeFigure == "rectangle")
            {
                Console.WriteLine(Math.Round(firstSide * secondSide, 3));
            }
            else if (typeFigure == "triangle")
            {
                Console.WriteLine(Math.Round(firstSide * secondSide / 2, 3));
            }
           

                
        }
    }
}
