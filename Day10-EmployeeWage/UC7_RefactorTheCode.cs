using System;

namespace Day10_EmployeeWage
{
    class UC7_RefactorTheCode
    {
        //Constants
       public const int is_Full_Time = 1;
       public const int is_Part_Time = 2;
       public const int Emp_Rate_Per_Hour = 20;
       public const int Num_Of_Working_Days = 20;
       public const int Max_Hrs_In_Month = 100;

        public static void ComputeEmployeeWage()
        {
            // Variables
            int empHrs = 0;
            int empWage = 0;
            int totalEmpWage = 0;
            int totalEmpHrs = 0;
            int totalWorkingDays = 0;
           
            while(totalEmpHrs <= Max_Hrs_In_Month && totalWorkingDays < Num_Of_Working_Days)
            {
                totalWorkingDays++;
                Random random = new Random();
                int empCheck = random.Next(0, 3);
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
                totalEmpHrs += empHrs;
                Console.WriteLine("Days:" + totalEmpHrs + "Employee Hours: " + totalEmpHrs);
            }
            totalEmpWage = totalEmpHrs * Emp_Rate_Per_Hour;
            Console.WriteLine("Total Employee Wage is: " + totalEmpWage);          
        }

        static void Main(string[] args)
        {
            ComputeEmployeeWage();
        }
    }
}
