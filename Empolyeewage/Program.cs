using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Empolyeewage
{
    class Program
    {
        static void Main(string[] args)
        {
            //UC1
            int isPresent = 3;
            Random random = new Random();
            int empInput = random.Next(0, 4);

            //selection statement
            if (isPresent == empInput)
                Console.WriteLine("Employee is Present");
            else
                Console.WriteLine("Empolyee Absent");
                Console.ReadLine();

        }
    }
}
