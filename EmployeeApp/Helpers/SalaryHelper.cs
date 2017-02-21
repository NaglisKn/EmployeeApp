using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EmployeeApp.Helpers
{
    public class SalaryHelper
    {
        double npd = 310;
        double IncomeTax = 0.15;
        double HealthInsurance = 0.06;
        double SocInsurance = 0.03;

        double SalaryGross = new double();
        public double GetGrossSalary(double salaryNet)
        {
            if (salaryNet>1000)
            {
                SalaryGross = salaryNet / (1-(IncomeTax + HealthInsurance + SocInsurance));
                return SalaryGross;
            }
            else if (salaryNet <= 335.3)
            {
                SalaryGross = (salaryNet - 46.5) / 0.76;
                return SalaryGross;
            }
            return SalaryGross;
        }
    }
}