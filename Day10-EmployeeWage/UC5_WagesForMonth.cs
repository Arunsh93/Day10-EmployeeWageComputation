using System;

namespace Day10_EmployeeWage
{
    class UC5_WagesForMonth
    {
        //Constants
       public const int is_Full_Time = 1;
       public const int is_Part_Time = 2;
       public const int Emp_Rate_Per_Hour = 20;
       public const int Num_Of_Working_Days = 20;
        static void Main(string[] args)
        {
            // Variables
            int empHrs = 0;
            int empWage = 0;
            int totalEmpWage = 0;
            Random random = new Random();
            int empCheck = random.Next(0, 3);
            for (int day = 0; day < Num_Of_Working_Days; day++)
            {
                switch (empCheck)
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
                totalEmpWage += empWage;
                Console.WriteLine("Employee Wage is: " + empWage);
            }
            Console.WriteLine("Total Employee Wage is: " + totalEmpWage);          
        }
    }
}
