using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace _13._100DaysAfterBirth
{
    class Program
    {
        static void Main(string[] args)
        {
            string date = Console.ReadLine();
            DateTime date1;
             date1 = DateTime.ParseExact(date, "dd-MM-yyyy", CultureInfo.InvariantCulture);
             date1 = date1.AddDays(999);

       

            Console.WriteLine(date1.ToString("dd-MM-yyyy"));

        }
    }
}
