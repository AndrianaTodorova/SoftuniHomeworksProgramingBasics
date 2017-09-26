using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.EnterEvenNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.Write("Enter even number: ");
            //int n = int.Parse(Console.ReadLine());
            //var even = true;

            //while (n % 2 != 0)
            //{
            //    even = false;
            //    Console.WriteLine("The number is not even.");
            //    break;

            //}
            //if (even)
            //{
            //    Console.WriteLine("Even number entered: {0}", n);
            //}
            int n = 0;
            while (true)
            {
                try
                {
                    Console.Write("Enter even number: ");
                    n = int.Parse(Console.ReadLine());


                    if (n % 2 == 0)
                        break;
                    Console.WriteLine("The number is not even.");

                }

                catch
                {
                    Console.WriteLine("Invalid number.");
                }
            }
            Console.WriteLine("Even number entered: {0}", n);
        
        }
    }
}
