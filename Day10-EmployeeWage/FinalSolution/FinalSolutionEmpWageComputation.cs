using System;
using System.Collections.Generic;
using System.Text;

namespace Day10_EmployeeWage
{
    class FinalSolutionEmpWageComputation:IComputeEmpWage
    {
        //Constants
        public const int is_Full_Time = 1;
        public const int is_Part_Time = 2;

        private LinkedList<CompanyEmpWage> companyEmpWageList;
        private Dictionary<string, CompanyEmpWage> companyEmpWageMap;

        public FinalSolutionEmpWageComputation()
        {
            this.companyEmpWageList = new LinkedList<CompanyEmpWage>();
            this.companyEmpWageMap = new Dictionary<string, CompanyEmpWage>();
        }

        public void addCompanyEmpWages(string company, int Emp_Rate_Per_Hour, int Num_Of_Working_Days, int Max_Hrs_In_Month)
        {
            CompanyEmpWage companyEmpWage = new CompanyEmpWage(company, Emp_Rate_Per_Hour, Num_Of_Working_Days, Max_Hrs_In_Month);
            this.companyEmpWageList.AddLast(companyEmpWage);
            this.companyEmpWageMap.Add(company, companyEmpWage);
        }

        public void ComputeEmployeeWage()
        {
            foreach(CompanyEmpWage companyEmpWage in this.companyEmpWageList)
            {
                companyEmpWage.getTotalEmpWage(this.ComputeEmployeeWage(companyEmpWage));
                Console.WriteLine(companyEmpWage.toString());
            }
        }
        public int ComputeEmployeeWage(CompanyEmpWage companyEmpWage)
        {
            // Variables
            int empHrs = 0;
            int totalEmpHrs = 0;
            int totalWorkingDays = 0;
           
            while(totalEmpHrs <= companyEmpWage.Max_Hrs_In_Month && totalWorkingDays < companyEmpWage.Num_Of_Working_Days)
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
           return totalEmpHrs * companyEmpWage.Emp_Rate_Per_Hour; 
        }

        public int getTotalWage(string company)
        {
            return this.companyEmpWageMap[company].totalEmpWage;
        }
    }
}
