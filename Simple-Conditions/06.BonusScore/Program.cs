using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.BonusScore
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            double bonusScore = 0;
            

            if (number < 100)
            {
                bonusScore = 5;
            }
            else if (number <= 1000)
            {
                bonusScore = number * 0.2;
            }
            else if (number > 1000)
            {
                bonusScore = number * 0.1;
            }
            if (number % 2 == 0)
            {
                bonusScore += 1;
            }
            else if (number % 10 == 5)
            {
                bonusScore += 2;
            }

            Console.WriteLine(bonusScore);
            Console.WriteLine(number + bonusScore);
        }
    }
}
