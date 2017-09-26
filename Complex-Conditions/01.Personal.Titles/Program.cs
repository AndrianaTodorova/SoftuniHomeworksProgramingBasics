using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Personal.Titles
{
    class Program
    {
        static void Main(string[] args)
        {
            double age = double.Parse(Console.ReadLine());
            char gender = char.Parse(Console.ReadLine());
            string name = "";

            if (gender == 'm')
            {
                if (age >= 16)
                {
                    name = "Mr.";
                }
                else 
                {
                    name = "Master";
                }

            }
            else if (gender == 'f')
            {
                if (age >= 16 )
                {
                    name = "Mrs.";
                }
                else 
                {
                    name = "Miss";
                }
                Console.WriteLine(name);

            }
        }
    }
}
