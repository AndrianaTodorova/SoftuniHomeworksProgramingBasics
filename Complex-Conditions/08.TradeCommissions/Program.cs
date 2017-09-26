using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.TradeCommissions
{
    class Program
    {
        static void Main(string[] args)
        {
            string city = Console.ReadLine().ToLower();
            double money = double.Parse(Console.ReadLine());
            double result = 0.0;

            switch (city)
            {
                case "sofia":
                    if (money >= 0 && money <= 500)
                    {
                        result = money * 0.05;
                    }
                    else if (money > 500 && money <= 1000)
                    {
                        result = money * 0.07;
                    }
                    else if (money > 1000 && money <= 10000)
                    {
                        result = money * 0.08;
                    }
                    else if (money > 10000)
                    {
                        result = money * 0.12;
                    }
                    break;
                case "plovdiv":
                    if (money >= 0 && money <= 500)
                    {
                        result = money * 0.055;
                    }
                    else if (money > 500 && money <= 1000)
                    {
                        result = money * 0.08;
                    }
                    else if (money > 1000 && money <= 10000)
                    {
                        result = money * 0.12;
                    }
                    else if (money > 10000)
                    {
                        result = money * 0.145;
                    }
                    
                    break;
                case "varna":
                    if (money >= 0 && money <= 500)
                    {
                        result = money * 0.045;
                    }
                    else if (money > 500 && money <= 1000)
                    {
                        result = money * 0.075;
                    }
                    else if (money > 1000 && money <= 10000)
                    {
                        result = money * 0.1;
                    }
                    else if (money > 10000)
                    {
                        result = money * 0.13;
                    }
                    break;
                default:
                    break;
            }
            if (result != 0)
            {
                Console.WriteLine($"{result:f2}");
            }
            else
            {
                Console.WriteLine("error");
            }
        }
    }
}
