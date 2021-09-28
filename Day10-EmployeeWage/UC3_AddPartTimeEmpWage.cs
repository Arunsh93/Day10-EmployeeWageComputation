using System;

namespace Day10_EmployeeWage
{
    class UC3_AddPartTimeEmpWage
    {
        static void Main(string[] args)
        {
            //Constants
            int is_Full_Time = 1;
            int is_Part_Time = 2;
            int Emp_Rate_Per_Hour = 20;

            // Variables
            int empHrs = 0;
            int empWage = 0;
            Random random = new Random();
            int empCheck = random.Next(0, 3);
            if(empCheck == is_Full_Time)
            {
                Console.WriteLine("Employee Present is for Full Time");
                empHrs = 8;
            }
            else if(empCheck == is_Part_Time)
            {
                Console.WriteLine("Employee is Present for Part Time");
                empHrs = 4;
            }
            else
            {
                Console.WriteLine("Employee is Absent");
            }

            empWage = empHrs * Emp_Rate_Per_Hour;
            Console.WriteLine("Employee Wage is: " + empWage);
        }
    }
}
