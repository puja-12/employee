// See https://aka.ms/new-console-template for more information
using System;
namespace employee
{
    public class Employee
    {

       // static void Main(string[] args)
       // {
       //     Console.WriteLine("Welcome to Employee wage computation program");
      //  }
            //first commit

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

            //second commit

            //int IS_FULL_TIME = 1;
            //int EMP_RATE_PER_HOUR = 20;
            //int empHrs = 0;
            //int empWage = 0;
            //Random random = new Random();
            //computation
            //int empCheck = random.Next(0, 2);
            //if (empCheck == IS_FULL_TIME)
            //{
            //    empHrs = 8;
            //}
            //else
            //{
            //    empHrs = 0;
            //        }
            //empWage = empHrs * EMP_RATE_PER_HOUR;
            //Console.WriteLine("Emp Wage :" + empWage);

            //third commit
            //int IS_FULL_TIME = 2;
            //int EMP_RATE_PER_HOUR = 20;
            //int IS_PART_TIME = 1;
            //int empHrs = 0;
            //int empWage = 0;
            //Random random = new Random();
            //int empCheck = random.Next(0, 3);
            //if (empCheck == IS_PART_TIME)
            //{
            //    empHrs = 4;
            //}
            //else if (empCheck == IS_FULL_TIME)
            //{
            //    empHrs = 8;
            //}
            //else
            //{
            //    empHrs = 0;
            //}
            //empWage = empHrs * EMP_RATE_PER_HOUR;
            //Console.WriteLine("Emp Wage :" + empWage);

            //fourth comment
       //     public const int IS_PART_TIME = 1;
       //public const int IS_FULL_TIME = 2;
       // public const int EMP_RATE_PER_HOUR = 20;

        //static void Main(string[] args)
        //{
        //    int empHrs = 0;
        //    int empWage = 0;
        //    Random random = new Random();
        //    int empCheck = random.Next(0, 3);
        //    switch (empCheck)
        //    {
        //        case IS_PART_TIME:
        //            empHrs = 4;
        //            break;
        //        case IS_FULL_TIME:
        //            empHrs = 8;
        //            break;
        //    }
        //    empWage = empHrs * EMP_RATE_PER_HOUR;
        //    Console.WriteLine("Emp Wage :" + empWage);

        //fifth commit

        public const int IS_PART_TIME = 1;
        public const int IS_FULL_TIME = 2;
        public const int EMP_RATE_PER_HOUR = 20;
        public const int NUM_OF_WORKING_DAYS = 2;

        static void Main(string[] args)
        {
            int empHrs = 0;
            int empWage = 0;
            int totalEmpWage = 0;
            for (int day = 0; day < NUM_OF_WORKING_DAYS; day++)
            {
                Random random = new Random();
                int empCheck = random.Next(0, 3);
                switch (empCheck)
                {
                    case IS_PART_TIME:
                        empHrs = 4;
                        break;
                    case IS_FULL_TIME:
                        empHrs = 8;
                        break;
                    default:
                        empHrs = 0;
                        break;
                }
                empWage = empHrs * EMP_RATE_PER_HOUR;
                totalEmpWage += empWage;
                Console.WriteLine("Emp Wage :" + empWage);
            }
            Console.WriteLine("Total Emp Wage :" + totalEmpWage);
        }

    }







}



       


    
    


