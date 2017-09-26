using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace фгкгкгн
{
    class Program
    {
        static void Main(string[] args)
        {
            double bitcoins = double.Parse(Console.ReadLine());
            double yuanQuantity = double.Parse(Console.ReadLine());
            double commision = double.Parse(Console.ReadLine());

            double bitcoinInLv = 1168;
            double yuanToUSD = 0.15;
            double USDInLv = 1.76;
            double euroInLv = 1.95;

            double bitcoinsInEUR = (bitcoins * bitcoinInLv) / euroInLv;
            double yuanInUSD = (yuanQuantity * yuanToUSD);
            double yuanInLv = yuanInUSD * USDInLv;
            double yuanInEUR = yuanInLv / 1.95;

            var result = Math.Round((bitcoinsInEUR + yuanInEUR) - (bitcoinsInEUR + yuanInEUR) * (commision / 100), 2);

             Console.WriteLine(result);
        }
    }
}
