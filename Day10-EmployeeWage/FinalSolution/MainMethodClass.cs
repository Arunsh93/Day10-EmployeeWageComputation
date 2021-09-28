using System;
using System.Collections.Generic;
using System.Text;

namespace Day10_EmployeeWage
{
    class MainMethodClass
    {
        static void Main(string[] args)
        {
            FinalSolutionEmpWageComputation empWageBuilder = new FinalSolutionEmpWageComputation();
            empWageBuilder.addCompanyEmpWages("DMART", 20, 20, 100);
            empWageBuilder.addCompanyEmpWages("Infosys", 20, 20, 100);
            empWageBuilder.addCompanyEmpWages("BridgeLabs", 20, 20, 100);
            empWageBuilder.ComputeEmployeeWage();
        }
    }
}
