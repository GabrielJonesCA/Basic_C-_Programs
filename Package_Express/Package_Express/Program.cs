﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Package_Express
{
    internal class Program
    {
        static void Main(string[] args)
        {


            Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");

            System.Threading.Thread.Sleep(1000);

            Console.WriteLine("Please enter the package weight:");
            int weight = Convert.ToInt32(Console.ReadLine());
            if (weight > 50)
            {
                Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day.");

            }
            else
            {
                Console.WriteLine("Please enter the package width:");
                int width = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Please enter the package height:");
                int height = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Please enter the package length:");
                int length = Convert.ToInt32(Console.ReadLine()); 

                if (width + height + length > 50) // used '+' opperator , but if total ment to multiply and not add you can use '*' opperator.
                {
                    Console.WriteLine("Package too big to be shipped via Package Express.");
                }
                else
                {
                    int area = width * height * length;
                    int total = (area * weight) / 100;

                    Console.WriteLine("Your estimated total for shipping this package is: $" + total + ".00, Thank you!");
                }
            }




                Console.ReadLine();



        }
    }
}
