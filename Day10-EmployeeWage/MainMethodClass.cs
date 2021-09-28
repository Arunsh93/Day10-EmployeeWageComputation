using System;
using System.Collections.Generic;
using System.Text;

namespace Day10_EmployeeWage
{
    class MainMethodClass
    {
        static void Main(string[] args)
        {
            UC9_EmpWageBuilderObject dmart = new UC9_EmpWageBuilderObject("DMART", 20, 20, 100);
            UC9_EmpWageBuilderObject wipro = new UC9_EmpWageBuilderObject("WIPRO", 20, 20, 100);
            Console.WriteLine("====================Company-1=========================");
            dmart.ComputeEmployeeWage();
            Console.WriteLine(dmart.toString());
            Console.WriteLine("====================Company-2=========================");
            wipro.ComputeEmployeeWage();
            Console.WriteLine(wipro.toString());
        }
    }
}
