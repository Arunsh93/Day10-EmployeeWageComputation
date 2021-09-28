using System;
using System.Collections.Generic;
using System.Text;

namespace Day10_EmployeeWage
{
    interface IComputeEmpWage
    {
        public void addCompanyEmpWages(string company, int Emp_Rate_Per_Hour, int Num_Of_Working_Days, int Max_Hrs_In_Month);

        public void ComputeEmployeeWage();

        public int getTotalWage(string company);
    }
}
