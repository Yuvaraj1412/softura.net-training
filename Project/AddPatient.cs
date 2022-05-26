using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
namespace Project.Models
{
    public class AddPatient
    {
        [Key]
        public int PatientID { get; set; }
        [Required(ErrorMessage = "Please Enter the PatientFirstName")]
        [RegularExpression("^[a-zA-Z0-9]*$", ErrorMessage = "Special Characters not Allowed")]
        public string PFirstName { get; set; }
        [Required(ErrorMessage = "Please Enter the PatientLastName")]
        [RegularExpression("^[a-zA-Z0-9]*$", ErrorMessage = "Special Characters not Allowed")]
        public string PLastName { get; set; }
        [Required(ErrorMessage = "Please select your Gender")]
        public string Sex { get; set; }
        [Range(0,100)]
        [Required(ErrorMessage = "Please enter your Age")]
        public int Age { get; set; }
        [Required(ErrorMessage ="Please fill this field")]
        public string DateOfBirth { get; set; }
    }
}
