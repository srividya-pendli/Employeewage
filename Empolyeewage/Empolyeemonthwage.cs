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
            //UC6
            //consants
            int empWage = 0, empHrs = 0, totalEmpWage = 0;
            const int FULL_TIME = 1;
            const int PART_TIME = 2;
            const int NUM_OF_WORKING_DAYS = 20;
            const int EMP_PER_HR = 20;
            const int MAX_WORKING_HRS = 100;
            int workingHrs = 0;
            int day = 1;
            Random random = new Random();

            while (day <= NUM_OF_WORKING_DAYS && workingHrs <= MAX_WORKING_HRS)
            {
                int empInput = random.Next(0, 3);

                switch (empInput)
                {
                    case FULL_TIME:
                        //Console.WriteLine("full time employee is present");
                        empHrs = 8;
                        break;
                    case PART_TIME:
                        //Console.WriteLine("part time employee is present");
                        empHrs = 4;
                        break;
                    default:
                        //Console.WriteLine("employee is absent");
                        empHrs = 0;
                        break;
                }
                empWage = EMP_PER_HR * empHrs;
                Console.WriteLine("Daily wage for day{0} is:{1}", day, empWage);
                totalEmpWage += empWage;
                workingHrs += empHrs;
                if (workingHrs > MAX_WORKING_HRS)
                {
                    workingHrs -= empHrs;
                    break;
                }
                day++;
            }
            Console.WriteLine("Totalwage for {0} days and working hrs:{1} and wage is:{2}", day - 1, workingHrs, totalEmpWage);
            Console.ReadLine();
        }
    }
}
