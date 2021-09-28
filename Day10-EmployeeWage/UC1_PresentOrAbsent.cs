using System;

namespace Day10_EmployeeWage
{
    class UC1_PresentOrAbsent
    {
        static void Main(string[] args)
        {
            int is_Full_Time = 1;
            int is_Part_Time = 2;
            Random random = new Random();
            int empCheck = random.Next(0, 3);
            if(empCheck == is_Full_Time)
            {
                Console.WriteLine("Employee Present is for Full Time");
            }
            else if(empCheck == is_Part_Time)
            {
                Console.WriteLine("Employee is Present for Part Time");
            }
            else
            {
                Console.WriteLine("Employee is Absent");
            }           
        }
    }
}
