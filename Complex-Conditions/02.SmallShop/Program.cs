using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.SmallShop
{
    class Program
    {
        static void Main(string[] args)
        {
            string product = Console.ReadLine().ToLower();
            string city = Console.ReadLine().ToLower();
            double quantity = double.Parse(Console.ReadLine());
            double result = 0.0;

            if (city == "sofia")
            {
                if (product == "coffee")
                {
                    result = 0.5 * quantity;
                }
                else if (product == "water")
                {
                    result = 0.8 * quantity;
                }
                else if (product == "beer")
                {
                    result = 1.2 * quantity;
                }
                else if (product == "sweets")
                {
                    result = 1.45 * quantity;
                }
                else if (product == "peanuts")
                {
                    result = 1.6 * quantity;
                }
            

            }
            else if (city == "plovdiv")
            {
                if (product == "coffee")
                {
                    result = 0.4 * quantity;
                }
                else if (product == "water")
                {
                    result = 0.7 * quantity;
                }
                else if (product == "beer")
                {
                    result = 1.15 * quantity;
                }
                else if (product == "sweets")
                {
                    result = 1.3 * quantity;
                }
                else if (product == "peanuts")
                {
                    result = 1.5 * quantity;
                }

            }
            else if (city == "varna")
            {
                if (product == "coffee")
                {
                    result = 0.45 * quantity;
                }
                else if (product == "water")
                {
                    result = 0.7 * quantity;
                }
                else if (product == "beer")
                {
                    result = 1.1 * quantity;
                }
                else if (product == "sweets")
                {
                    result = 1.35 * quantity;
                }
                else if (product == "peanuts")
                {
                    result = 1.55 * quantity;
                }
                Console.WriteLine(result);

            }
        }
    }
}
