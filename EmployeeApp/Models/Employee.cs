using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
namespace EmployeeApp.Models
{
    public class Employee
    {
        public int ID { get; set; }

        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        [Required]
        public int SalaryNet { get; set; }
        public byte[] Image { get; set; }
    }
}