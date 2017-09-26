using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.SumSeconds
{
    class Program
    {
        static void Main(string[] args)
        {
            int first = int.Parse(Console.ReadLine());
            int second = int.Parse(Console.ReadLine());
            int third = int.Parse(Console.ReadLine());

            int result = first + second + third;

            double minutes = 0;
            double seconds = 0;
            if ( result < 60)
            {
                seconds = result;
            }
            else if (result < 120)
            {
                minutes = 1;
                seconds = result - 60;    
            }
            else if (result <= 150)
            {
                minutes = 2;
                seconds = result - 120;
            }



            Console.WriteLine("{0}:{1:00}", minutes, seconds);
            
        }
    }
}
