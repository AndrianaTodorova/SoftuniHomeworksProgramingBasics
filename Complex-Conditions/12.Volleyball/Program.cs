using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.Volleyball
{
    class Program
    {
        static void Main(string[] args)
        {
            string typeOfYear = Console.ReadLine();
            var hollidays = double.Parse(Console.ReadLine());
            var weekends = double.Parse(Console.ReadLine());

            var result = 48 - weekends;
            var saturdayPlay = result * 3 / 4;
            var weekendsInTown =48 - result;
            var holidayPlay = hollidays * 2 / 3;

            var allGames = saturdayPlay + weekendsInTown + holidayPlay;
            var forLeapYear = allGames * 0.15;
            var result2 = allGames + forLeapYear;


            if (typeOfYear == "leap")
            {
                Console.WriteLine(Math.Floor(result2));
            }
            else if (typeOfYear == "normal")
            {
                Console.WriteLine(Math.Floor(allGames));
            }
        }
    }
}
