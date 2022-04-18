// See https://aka.ms/new-console-template for more information
using System;
namespace employee
{
    public class Employee
    {
        static void Main(string[] args)
        {
            int ispresent = 1;
            Random random = new Random();

            int empCheck = random.Next(0, 2);
            if (empCheck == ispresent)
            {
                Console.WriteLine("employee is present");

            }
            else
            {
                Console.WriteLine("employee is absent");
            }
        }
    }
}

       


    
    


