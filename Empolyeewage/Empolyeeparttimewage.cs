﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Empolyeewage
{
    class Program
    {
        /// <summary>
        /// Define the entry ponit of the application.
        /// </summary>
        /// <param name="args">The arguments.</param>
        static void Main(string[] args)
        {
            //UC3
            int FullTime = 1, PartTime = 2;
            int empRatePerHr = 20;
            int empHrs = 0;
            int empWage = 0;
            Random random = new Random();
            int empInput = random.Next(0, 3);

            //selection statement
            if (FullTime == empInput)
            {
                Console.WriteLine(" fulltime employee is present");
                empHrs = 8;
            }
            else if (PartTime == empInput)
            {
                Console.WriteLine(" parttime employee is present");
                empHrs = 4;
            }
            else
            {
                Console.WriteLine("employee is absent");
                empHrs = 0;
            }
            empWage = empRatePerHr * empHrs;
            Console.WriteLine("Daily employee wage:" + empWage);
            Console.ReadLine();
        }
    }
}
