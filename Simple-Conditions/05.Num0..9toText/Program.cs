using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Num0._._9toText
{
    class Program
    {
        static void Main(string[] args)
        {
            var num = int.Parse(Console.ReadLine());
            string[] numbersinwords = new string[] { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };
            int[] numbers = new int[10];
            for (int i = 0; i <= 9; i++)
            {
                numbers[i] = i;
            }
            if (num > numbers[numbers.Length - 1])
            {
                Console.WriteLine("number too big");
            }
            else
            {
                for (int i = 0; i < numbers.Length; i++)
                {
                    if (num == numbers[i])
                    {
                        Console.WriteLine(numbersinwords[i]);
                    }
                }
            }
        }
    }
}
  