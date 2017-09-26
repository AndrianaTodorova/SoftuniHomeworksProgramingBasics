using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.EqualPairs
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int sumFirstPair = 0;
            int sumSecondPair = 0;
            int sumThirdPair = 0;

            for (int i = 0; i <  n; i++)
            {
                int num = int.Parse(Console.ReadLine());

                sumFirstPair += num;
            }
            for (int i = 0; i < n; i++)
            {
                int num = int.Parse(Console.ReadLine());

                sumSecondPair += num;
            }
            for (int i = 0; i < n; i++)
            {
                int num = int.Parse(Console.ReadLine());

                sumThirdPair += num;
            }
            if (sumFirstPair == sumSecondPair && sumSecondPair == sumThirdPair)
            {
                Console.WriteLine("Yes, value = " + sumSecondPair);
            }


        }
    }
}
