using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.CurrencyConverter
{
    class Program
    {
        static void Main(string[] args)
        {
            double n = double.Parse(Console.ReadLine());
            string first = Console.ReadLine();
            string second = Console.ReadLine();

            if (first == "USD")
            {
                if (second == "BGN")
                {
                    Console.WriteLine("{0}", Math.Round(n * 1.79549, 2));
                }
                else if (second == "EUR")
                {
                    Console.WriteLine("{0}", Math.Round(n * 1.95583, 2));
                }
                else if (second == "GBP")
                {
                    Console.WriteLine("{0}", Math.Round(n * 2.53405, 2));
                }

            }
            if (first == "BGN")
            {
                if (second == "USD")
                {
                    Console.WriteLine("{0}", Math.Round(n / 1.79549, 2));
                }
                else if (second == "EUR")
                {
                    Console.WriteLine("{0}", Math.Round(n / 1.95583, 2));
                }
                else if (second == "GBP")
                {
                    Console.WriteLine("{0}", Math.Round(n / 2.53405, 2));
                }
            }

            if (first == "EUR")
            {
                if (second == "BGN")
                {
                    Console.WriteLine("{0}", Math.Round(n * 2.53405, 2));
                }
                else if (second == "USD")
                {
                    Console.WriteLine("{0}", Math.Round(n * 1.08930, 2));
                }
                else if (second == "GBP")
                {
                    Console.WriteLine("{0}", Math.Round(n * 2.53405, 2));
                }
            }
            if (first == "GBP")
                if (second == "BGN")
                {
                    Console.WriteLine("{0}", Math.Round(n * 1.79549, 2));
                }
                else if (second == "USD")
                {
                    Console.WriteLine("{0}", Math.Round(n * 1.79549 , 2));//Тука беше разликата.
                }
                else if (second == "EUR")
                {
                    Console.WriteLine("{0}", Math.Round(n * 1.95583, 2));
                }
        }
    }
}
