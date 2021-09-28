using System;

namespace Day10_EmployeeWage
{
    class UC9_EmpWageBuilderObject
    {
        //Constants
       public const int is_Full_Time = 1;
       public const int is_Part_Time = 2;

       private string company;
       private int Emp_Rate_Per_Hour;
       private int Num_Of_Working_Days;
       private int Max_Hrs_In_Month;
       private int totalEmpWage = 0;
        public UC9_EmpWageBuilderObject(string company, int Emp_Rate_Per_Hour, int Num_Of_Working_Days, int Max_Hrs_In_Month)
        {
            this.company = company;
            this.Emp_Rate_Per_Hour = Emp_Rate_Per_Hour;
            this.Num_Of_Working_Days = Num_Of_Working_Days;
            this.Max_Hrs_In_Month = Max_Hrs_In_Month;
        }
        public void ComputeEmployeeWage()
        {
            // Variables
            int empHrs = 0;
            int empWage = 0;
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
            Console.WriteLine("Total Employee Wage of Comapny: " + company + " is " + totalEmpWage);
        }

        public string toString()
        {
            return "Total Wage for Company: " + this.company + " is " + this.totalEmpWage;
        }
    }
}
