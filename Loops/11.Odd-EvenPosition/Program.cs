using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.Odd_EvenPosition
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double evenSum = 0;
            double oddSum = 0;

            double max = double.MinValue;
            double min = double.MaxValue;
            double oddMax = double.MinValue;
            double oddMin = double.MaxValue;

            for (int i = 0; i < n; i++)
            {
                double num = double.Parse(Console.ReadLine());
                if (i % 2 == 0)
            {
                oddSum += num;
                //Тези иф-ове не трябва да са скачени
                //Тоест не трябва да са иф и после елс иф а два отделни иф-а
                //Това е така защото ако въведеш само едно число от конзолата например 1 то то ще бъде и най-голямото
                //и най-малкото което същестува от въведените
                if (num < oddMin)
                {
                    oddMin = num;
                }

                if (num > oddMax)
                {
                    oddMax = num;
                }
            }
            else
            {
                //тук отново трябва да са два отделни иф-а поради същата причина
                evenSum += num;
                if (num < min)
                {
                    min = num;
                }

                if (num > max)
                {
                    max = num;
                }
            }

        }

        Console.WriteLine("OddSum={0},", oddSum);
            //това е съкратен запис за иф-елс клауза и работи по слдния начин
            // (логическо условие) ? (кодът който ще се изпълни ако е истина) : (кодът който ще се изпълни ако не е)
            Console.WriteLine("OddMin={0},", oddMin == double.MaxValue? "No" : oddMin.ToString());
            Console.WriteLine("OddMax={0},", oddMax == double.MinValue? "No" : oddMax.ToString());
            Console.WriteLine("EvenSum={0},", evenSum);
            Console.WriteLine("EvenMin={0},", min == double.MaxValue? "No" : min.ToString());
            Console.WriteLine("EvenMax={0}", max == double.MinValue? "No" : max.ToString());
        }
    }
}
