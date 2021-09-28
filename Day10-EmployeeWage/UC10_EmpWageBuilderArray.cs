using System;

namespace Day10_EmployeeWage
{
    class UC10_EmpWageBuilderArray
    {
        //Constants
        public const int is_Full_Time = 1;
        public const int is_Part_Time = 2;

        private int numberOfCompany = 0;
        private CompanyEmpWage[] companyEmpWagesArray;

        public UC10_EmpWageBuilderArray()
        {
            this.companyEmpWagesArray = new CompanyEmpWage[5];
        }

        public void addCompanyEmpWages(string company, int Emp_Rate_Per_Hour, int Num_Of_Working_Days, int Max_Hrs_In_Month)
        {
            companyEmpWagesArray[this.numberOfCompany] = new CompanyEmpWage(company, Emp_Rate_Per_Hour, Num_Of_Working_Days, Max_Hrs_In_Month);
            numberOfCompany++;
        }

        public void ComputeEmployeeWage()
        {
            for(int i =0; i < numberOfCompany; i++)
            {
                companyEmpWagesArray[i].getTotalEmpWage(this.ComputeEmployeeWage(this.companyEmpWagesArray[i]));
                Console.WriteLine(this.companyEmpWagesArray[i].toString());
            }
        }
        public int ComputeEmployeeWage(CompanyEmpWage companyEmpWage)
        {
            // Variables
            int empHrs = 0;
            int empWage = 0;
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
    }
}
