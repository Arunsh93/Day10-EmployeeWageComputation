using System;
using System.Collections.Generic;
using System.Text;

namespace Day10_EmployeeWage
{
    class CompanyEmpWage
    {
        public string company;
        public int Emp_Rate_Per_Hour;
        public int Num_Of_Working_Days;
        public int Max_Hrs_In_Month;
        public int totalEmpWage;

        public CompanyEmpWage(string company, int Emp_Rate_Per_Hour, int Num_Of_Working_Days, int Max_Hrs_In_Month)
        {
            this.company = company;
            this.Emp_Rate_Per_Hour = Emp_Rate_Per_Hour;
            this.Num_Of_Working_Days = Num_Of_Working_Days;
            this.Max_Hrs_In_Month = Max_Hrs_In_Month;
        }
        public void getTotalEmpWage(int totalEmpWage)
        {
            this.totalEmpWage = totalEmpWage;
        }

        public string toString()
        {
            return "Total Employee Wages for Company: " + this.company + " is " + this.totalEmpWage;
        }
    }
}

