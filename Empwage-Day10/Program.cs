using System;

namespace Empwage_Day10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-------------------Total Wage When Queried By Company--------------------");
            EmpWageBuilder empWageBuilder = new EmpWageBuilder();
            empWageBuilder.addCompanyEmpWage("infosys",20,2,10);
            empWageBuilder.addCompanyEmpWage("Wipro", 10, 4, 20);
            empWageBuilder.computeEmpWage();
            Console.WriteLine("-----------------------------------------------");
            Console.WriteLine("Total Wage For infosys Company: " + empWageBuilder.getTotalWage("infosys"));
         //   Console.WriteLine("Hello World!");
        }
    }
}
