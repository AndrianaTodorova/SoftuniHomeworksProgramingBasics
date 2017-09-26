using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.SleepyCatTom
{
    class Program
    {
        static void Main(string[] args)
        {
            int dayOff = int.Parse(Console.ReadLine());

            var playingDayOff = dayOff * 127;
            var playingWorkDays = (365 - dayOff) * 63;
            var result = playingDayOff + playingWorkDays;
            var minutesPerYear = 30000;
            var lastResult = Math.Abs(minutesPerYear - result);

            var hours = lastResult / 60;
            var minutes = lastResult % 60;

            if (minutesPerYear >= result)
            {
                 
                Console.WriteLine("Tom sleeps well");
                Console.WriteLine("{0} hours and {1} minutes less for play", hours, minutes);
            }
            else
            {
                Console.WriteLine("Tom will run away");
                Console.WriteLine("{0} hours and {1} minutes more for play", hours, minutes);
            }
        }
    }
}
