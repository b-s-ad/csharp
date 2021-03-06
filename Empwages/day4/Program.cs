using System;
using day4.UC9;
using Day4.UC10;
using Day4.UCLast_FinalSolution;

namespace day4
{
    class Program
    {
        public static void Main(string[] args)
        {
            //Console.WriteLine("Welcome to Employee Wage Computation Program");
            //UC1_EmployeeAttendance.GetAttendance();
            //UC2_EmpWage.EmpWage();
            //UC3_PartTimeEmpWage.PartTimeEmpWage(); 
            //UC4_EmpWageUsingSwitch.EmpWageUsingSwitch();
            //UC5_CalculateWagesFor20DaysInMonth.CalculateWagesFor20DaysInMonth();
            //UC6_CalculateWageTill100HrsOr20IsReached.CalculateWageTill100HrsOr20IsReached();
            //UC7_ComputeEmpWageUsingClassMethod.ComputeEmpWage();
            //UC8_ComputeEmpWageForMultipleCompanies.ComputeEmpWage("MNC", 25, 2, 10);

            /*#region UC9

            EmpWageBuilderObject dMart = new EmpWageBuilderObject("DMart", 20, 2, 10);
            EmpWageBuilderObject reliance = new EmpWageBuilderObject("Reliance", 10, 4, 20);
            dMart.computeEmpWage();
            Console.WriteLine(dMart.toString());
            reliance.computeEmpWage();
            Console.WriteLine(reliance.toString());

            #endregion UC ending*/


            /*#region UC10

            EmpWageBuilderArray empWageBuilder = new EmpWageBuilderArray();
            empWageBuilder.addCompanyEmpWage("DMart", 20, 2, 10);
            empWageBuilder.addCompanyEmpWage("Reliance", 10, 4, 20);
            empWageBuilder.computeEmpWage();

            #endregion UC10 ending*/

            #region FinalSolution

            EmpWageBuilder empWageBuild = new EmpWageBuilder();
            empWageBuild.addCompanyEmpWage("DMart", 20, 2, 10);
            empWageBuild.addCompanyEmpWage("Reliance", 10, 4, 20);
            empWageBuild.computeEmpWage();

            #endregion FinalSolution ending 



            Console.ReadKey();
        }
    }
}
