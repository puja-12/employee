// See https://aka.ms/new-console-template for more information
using System;
namespace employee
{
    public class Employee
    {

        public const int IS_PART_TIME = 1;
        public const int IS_FULL_TIME = 2;
        public const int EMP_RATE_PER_HOUR = 20;
        public const int NUM_OF_WORKING_DAYS = 2;
        public const int MAX_HRS_IN_MONTH = 10;


        static void Main(string[] args)
        {
            int empHrs = 0;
            int totalempHrs = 0;
            int totalWorkingDays = 0;
        while(totalempHrs<= MAX_HRS_IN_MONTH && totalWorkingDays < NUM_OF_WORKING_DAYS)
            {
                totalWorkingDays++;
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
               
                totalempHrs += empHrs;
                Console.WriteLine("Day#:" + totalWorkingDays + "empHrs : " + empHrs);
            }
            int totalempWage = totalempHrs * EMP_RATE_PER_HOUR;
            Console.WriteLine("totalempWage :" + totalempWage);;
        }

    }







}



       


    
    


