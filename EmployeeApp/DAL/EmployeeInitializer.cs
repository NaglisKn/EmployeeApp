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
            new Employee{FirstName="Carson",LastName="Alexander",SallaryNet=500},
            new Employee{FirstName="Meredith",LastName="Alonso",SallaryNet=600},
            new Employee{FirstName="Arturo",LastName="Anand",SallaryNet=700},
            new Employee{FirstName="Gytis",LastName="Barzdukas",SallaryNet=800},
            new Employee{FirstName="Yan",LastName="Li",SallaryNet=550},
            new Employee{FirstName="Peggy",LastName="Justice",SallaryNet=600},
            new Employee{FirstName="Laura",LastName="Norman",SallaryNet=650},
            new Employee{FirstName="Nino",LastName="Olivetto",SallaryNet=686}
            };

            employees.ForEach(s => context.Employees.Add(s));
            context.SaveChanges();
        }
    }
}