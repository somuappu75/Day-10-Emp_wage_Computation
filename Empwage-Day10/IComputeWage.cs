using System;
using System.Collections.Generic;
using System.Text;

namespace Empwage_Day10
{
    public interface IComputeWage
    {
       // public void addcompanyEmpWage(string company, int empRatePerHour, int numofWorkingDays, int maxHoursPerMonth);

        public void computeEmpWage();

       // public int getTotalwage(string company);


    }

    public class CompanyEmpWage
    {
        public string company;
        public int empRatePerHour;
        public int numofWorkingDays;
        public int maxHoursPerMonth;
        public int totalEmpWage;

        public CompanyEmpWage(string company, int empRatePerHour, int numofWorkingDays, int maxHoursPerMonth)
        {
            this.company = company;
            this.empRatePerHour = empRatePerHour;
            this.numofWorkingDays = numofWorkingDays;
            this.maxHoursPerMonth = maxHoursPerMonth;

        }

    }
}
