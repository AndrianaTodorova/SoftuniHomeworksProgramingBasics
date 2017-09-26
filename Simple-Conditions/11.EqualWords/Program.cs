using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.EqualWords
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstWord = Console.ReadLine();
            string secondWord = Console.ReadLine();
            firstWord = firstWord.ToLower();
            secondWord = secondWord.ToLower();

            if (firstWord != secondWord)
            {
                Console.WriteLine("no");
            }
            else if (firstWord == secondWord)
            {
                Console.WriteLine("yes");
            }

            
        }
    }
}
