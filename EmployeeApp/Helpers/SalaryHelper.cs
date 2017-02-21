using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EmployeeApp.Helpers
{
    public class SalaryHelper
    {
        // All constans according to latest data
        const double npd = 310;
        const double IncomeTax = 0.15;
        const double HealthInsurance = 0.06;
        const double SocInsurance = 0.03;

        double SalaryGross = new double();
        //Calculates Gross salary from input Net salary
        public double GetGrossSalary(double salaryNet)
        {
            if (salaryNet>759)
            {
                SalaryGross = salaryNet / (1-(IncomeTax + HealthInsurance + SocInsurance));
                return SalaryGross;
            }
            else if (salaryNet < 336)
            {
                SalaryGross = (salaryNet - 46.5) / 0.76;
                return SalaryGross;
            }
            else
            {
                //System doesn't support calculating NPD from given NET sallary. Needs to be updated.
                SalaryGross = salaryNet / (1 - (IncomeTax + HealthInsurance + SocInsurance));
                return SalaryGross;
            }
            return SalaryGross;
        }
    }
}