using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using EmployeeApp.Models;

namespace EmployeeApp.DAL
{
    public class EmployeeInitializer : System.Data.Entity.DropCreateDatabaseIfModelChanges<EmployeeContext>
    {
        protected override void Seed(EmployeeContext context)
        {
            var employees = new List<Employee>
            {
            new Employee{FirstName="Carson",LastName="Alexander",SalaryNet=500},
            new Employee{FirstName="Meredith",LastName="Alonso",SalaryNet=600},
            new Employee{FirstName="Arturo",LastName="Anand",SalaryNet=700},
            new Employee{FirstName="Gytis",LastName="Barzdukas",SalaryNet=800},
            new Employee{FirstName="Yan",LastName="Li",SalaryNet=550},
            new Employee{FirstName="Peggy",LastName="Justice",SalaryNet=600},
            new Employee{FirstName="Laura",LastName="Norman",SalaryNet=650},
            new Employee{FirstName="Nino",LastName="Olivetto",SalaryNet=686}
            };

            employees.ForEach(s => context.Employees.Add(s));
            context.SaveChanges();
        }
    }
}