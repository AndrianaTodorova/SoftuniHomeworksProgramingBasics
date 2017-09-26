using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.DailyStamp
{
    class Program
    {
        static void Main(string[] args)
        {
            var workingDays = double.Parse(Console.ReadLine());
            var moneyPerDay = double.Parse(Console.ReadLine());
            var dollarExchange = double.Parse(Console.ReadLine());

            double oneMonthPayment = workingDays * moneyPerDay;
            double moneyPerYear = (oneMonthPayment * 12) + (oneMonthPayment * 2.5);
            double tax = moneyPerYear * 0.25;
            double yearIncome = (moneyPerYear - tax) * dollarExchange;
            double result = yearIncome / 365;

            Console.WriteLine("{0:F2}", result);
        }
    }
}
