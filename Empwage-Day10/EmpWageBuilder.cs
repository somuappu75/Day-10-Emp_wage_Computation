using System;
using System.Collections.Generic;
using System.Text;

namespace Empwage_Day10
{
   public class EmpWageBuilder : IComputeWage
    {
        public const int IS_PART_TIME= 1;
        public const int  IS_FULL_TIME= 2;

        private LinkedList<ComputeEmpWage> companyEmpWageList;
        private Dictionary<string, ComputeEmpWage> companyToEmpWageMap;

        public EmpWageBuilder()
        {
            this.companyEmpWageList = new LinkedList<ComputeEmpWage>();
            this.companyToEmpWageMap = new Dictionary<string, ComputeEmpWage>();

        }

        public void addCompanyEmpWage(string company,int empRatePerHour,int numofWorkingDays,int maxHoursPerMonth)
        {
            ComputeEmpWage computeEmpWage = new ComputeEmpWage(company, empRatePerHour, numofWorkingDays, maxHoursPerMonth);
            this.companyEmpWageList.AddLast(computeEmpWage);
            this.companyToEmpWageMap.Add(company, computeEmpWage);

        }
        public void computeEmpWage()
        {
            foreach(ComputeEmpWage computeEmpWage1 in this.companyEmpWageList)
            {
                computeEmpWage1.setTotalEmpWage(this.computeEmpWage(computeEmpWage1));
                Console.WriteLine(computeEmpWage1.toString());

            }

        }
        private int computeEmpWage(ComputeEmpWage computeEmpWage)
        {
            int empHrs = 0, totalmpHrs = 0, totalworkingDays = 0;
            while(totalmpHrs<=computeEmpWage.maxHoursPerMonth && totalworkingDays < computeEmpWage.numofWorkingDays)
            {
                totalworkingDays++;
                Random random = new Random();
                int empcheck = random.Next(0, 3);
                switch (empcheck)
                {
                    case IS_PART_TIME:
                        empHrs = 4;
                        break;
                    case IS_FULL_TIME:
                        empHrs = 8;
                        break;
                    default:
                        empHrs = 0;
                        break;
                }
                totalmpHrs += empHrs;
                Console.WriteLine("Day#: " + totalworkingDays + " Emp Hrs : " + empHrs);

            }
            int totalEmpWage= totalmpHrs * computeEmpWage.empRatePerHour;
            Console.WriteLine("Total Emp Wage For Company:" + computeEmpWage.company + " is :" + totalEmpWage);

           return totalEmpWage;

            return computeEmpWage.totalEmpWage;
            
            
        }
        public int getTotalWage(string company)
        {
            return this.companyToEmpWageMap[company].totalEmpWage;
        }


        

    }
}
