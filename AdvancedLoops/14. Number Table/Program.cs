using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14.Number_Table
{
    class Program
    {
        static void Main(string[] args)
        {
            //int n = int.Parse(Console.ReadLine());


            //for (int row = 0; row < n; row++)
            //{
            //    for (int col = 0; col <n ; col++)
            //    {
            //       var num = row + col + 1;
            //        if (num > n)
            //        {
            //            num = 2 * n - num;
            //            Console.Write(num + " ");
            //        }
            //    }
            //    Console.WriteLine();
            //}
            int n = int.Parse(Console.ReadLine());
            int num = 0;

            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= n; j++)
                {
                    num = i + j - 1;

                    if (num > n)
                    {
                        for (int k = 1; k <= n - j + 1; k++)
                        {
                            Console.Write("{0} ", n - k);
                        }
                        break;
                    }

                    Console.Write("{0} ", num);
                }
                Console.WriteLine();
            }


        }
    }
}
