using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.Diamond
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int stars = 0;
            int leftRight = (n - 1)/2 ;
            int mid = (n - 2) * (leftRight - 2);
            if (n % 2 == 0)
            {
                stars = 2;
            }
            else
            {
                stars = 1;
            }
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("{0}{1}{0}", new string ('-', (leftRight-1)/2),
                    new string ('*', stars));
                mid += 1;
                leftRight -= 1;
                
            }

        }
    }
}
