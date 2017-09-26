using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.HalfSumElement
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
           
            int sumNumbers = 0;
            int num = 0;
            int max = int.MinValue;


            for (int i = 0; i < n; i++)
            {
                 num = int.Parse(Console.ReadLine());
                if (num > max)
                {
                    max = num;
                }
                sumNumbers += num;
                
            }
            sumNumbers = sumNumbers - max;
            if (sumNumbers == max)
            {
                Console.WriteLine("Yes, sum = " + sumNumbers);
            }
            else
            {
                Console.WriteLine("No, diff = " + Math.Abs(sumNumbers - max));
            }
        
        }
    }
}
