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
        [Range(0, 50000, ErrorMessage = "Check salary you entered and try again.")]
        [DisplayFormat(DataFormatString = "{0:N}", ApplyFormatInEditMode = true)]
        public int SalaryNet { get; set; }
        public byte[] Image { get; set; }
    }
}