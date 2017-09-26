using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Adventure
{
    class Program
    {
        static void Main(string[] args)
        {
            int budget = int.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            string sleepPlace = "";
            string place = "";


            if (budget <= 100 )
            {
                if (season == "summer" && budget <= 50)
                {
                    sleepPlace = "Camp";
                    Console.WriteLine("Somewhere in Bulgaria");
                    Console.WriteLine("{0}- {1:F2}",sleepPlace,  budget * 0.3);

                }

            }
       
        }
    }
}
