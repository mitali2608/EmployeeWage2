using System;

namespace EmployeeWage2
{
    class Program
    {
        static void Main(string[] args)
        {
            UC1_EmployeeAttendance E1 = new UC1_EmployeeAttendance();
            E1.GetAttendance();
            UC2_EmpWage E2 = new UC2_EmpWage();
            E2.EmpWage();
            UC3_PartTimeEmpWage E3 = new UC3_PartTimeEmpWage();
            E3.PartTimeEmpWage();
            UC4_EmpWageUsingSwitch E4 = new UC4_EmpWageUsingSwitch();
            E4.EmpWageUsingSwitch();
            UC5_CalculateWagesFor20DaysInMonth E5 = new UC5_CalculateWagesFor20DaysInMonth();
            E5.CalculateWagesFor20DaysInMonth();
            UC6_CalculateWageTill100HrsOr20IsReached E6 = new UC6_CalculateWageTill100HrsOr20IsReached();
            E6.CalculateWageTill100HrsOr20IsReached();
            UC7_ComputeEmpWageUsingClassMethod E7 = new UC7_ComputeEmpWageUsingClassMethod();
            E7.ComputeEmpWage();
            UC8_ComputeEmpWageForMultipleCompanies E8 = new UC8_ComputeEmpWageForMultipleCompanies();
            E8.ComputeEmpWage("xyz", 10, 2, 8);
            Console.ReadKey();
        }

      
    }
}
