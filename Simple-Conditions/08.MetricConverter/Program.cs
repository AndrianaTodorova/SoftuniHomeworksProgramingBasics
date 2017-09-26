using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.MetricConverter
{
    class Program
    {
        static void Main(string[] args)
        {
            double number = double.Parse(Console.ReadLine());
            string metric = Console.ReadLine();
            string metric1 = Console.ReadLine();

            double valueToMeters = 0;
            double result = 0;

            double millimeters = 1000;
            double centimeters = 100;
            double miles = 0.000621371192;
            double inches = 39.3700787;
            double kilometers = 0.001;
            double feet = 3.2808399;
            double yards = 1.0936133;

            if (metric == "m")
            {
                valueToMeters = number;
            }
            else if (metric == "mm")
            {
                valueToMeters = number / millimeters;
            }
            else if (metric == "cm")
            {
                valueToMeters = number / centimeters;
            }
            else if (metric == "mi")
            {
                valueToMeters = number / miles;
            }
            else if (metric == "in")
            {
                valueToMeters = number / inches;
            }
            else if (metric == "km")
            {
                valueToMeters = number / kilometers;
            }
            else if (metric == "ft")
            {
                valueToMeters = number / feet;
            }
            else if (metric == "yd")
            {
                valueToMeters = number / yards;
            }

            if (metric1 == "m")
            {
                result = valueToMeters;
            }
            else if (metric1 == "mm")
            {
                result = valueToMeters * millimeters;
            }
            else if (metric == "cm")
            {
                result = valueToMeters * centimeters;
            }
            else if (metric == "mi")
            {
                result = valueToMeters * miles;
            }
            else if (metric == "in")
            {
                result = valueToMeters * inches;
            }
            else if (metric == "km")
            {
                result = valueToMeters * kilometers;
            }
            else if (metric == "ft")
            {
                result = valueToMeters * feet;
            }
            else if (metric == "yd")
            {
                result = valueToMeters * yards;
            }

            Console.WriteLine(result + " " + metric1);


        }
    }
}

