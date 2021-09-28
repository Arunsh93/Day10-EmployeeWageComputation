using System;

namespace Day10_EmployeeWage
{
    class UC4_UsingSwitchCase
    {
        //Constants
       public const int is_Full_Time = 1;
       public const int is_Part_Time = 2;
       public const int Emp_Rate_Per_Hour = 20;
        static void Main(string[] args)
        {
            // Variables
            int empHrs = 0;
            int empWage = 0;
            Random random = new Random();
            int empCheck = random.Next(0, 3);
            switch(empCheck)
            {
                case is_Full_Time:
                    empHrs = 8;
                    Console.WriteLine("Employee is Full Time");
                    break;

                case is_Part_Time:
                    empHrs = 4;
                    Console.WriteLine("Employee is Present for Part Time");
                    break;

                default:
                    empHrs = 0;
                    Console.WriteLine("Employee is Absent");
                    break;
            }
            empWage = empHrs * Emp_Rate_Per_Hour;
            Console.WriteLine("Employee Wage is: " + empWage);
        }
    }
}
