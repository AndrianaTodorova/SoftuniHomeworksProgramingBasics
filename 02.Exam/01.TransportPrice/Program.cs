using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.TransportPrice
{
    class Program
    {
        static void Main(string[] args)
        {
            int kilometers = int.Parse(Console.ReadLine());
            string dayOrNight = Console.ReadLine();
            double result = 0;

            if (dayOrNight == "day")
            {
            
             if (kilometers <= 19)
                {
                    result = 0.70 + (kilometers * 0.79);
                }
                else if (kilometers >= 20 && kilometers < 100)
                {
                    result = kilometers * 0.09;
                }
                else if (kilometers >= 100)
                {
                    result = kilometers * 0.06;
                }
            }


            if (dayOrNight == "night")
            {
            
                if (kilometers <= 19)
                {
                    result = 0.70 + kilometers * 0.90;
                }
                else if (kilometers >= 20 && kilometers < 100)
                {
                    result = kilometers * 0.09;
                }
                else if (kilometers >= 100)
                {
                    result = kilometers * 0.06;
                }
            }
            Console.WriteLine(Math.Round (result, 2));

            
        }
    }
}
