// See https://aka.ms/new-console-template for more information
using System;
namespace employee
{
    public class Employee
    {
        static void Main(string[] args)
        {
            //int ispresent = 1;
            // Random random = new Random();

            //int empCheck = random.Next(0, 2);
            //if (empCheck == ispresent)
            //{
            //   Console.WriteLine("employee is present");

            //}
            //else
            // {
            //   Console.WriteLine("employee is absent");
            // }
            int IS_FULL_TIME = 1;
            int EMP_RATE_PER_HOUR = 20;
            int empHrs = 0;
            int empWage = 0;
            Random random = new Random();
            //computation
            int empCheck = random.Next(0, 2);
            if (empCheck == IS_FULL_TIME)
            {
                empHrs = 8;
            }
            else
            {
                empHrs = 0;
                    }
            empWage = empHrs * EMP_RATE_PER_HOUR;
            Console.WriteLine("Emp Wage :" + empWage);

        }
    }
}

       


    
    


