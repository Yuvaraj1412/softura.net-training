using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Project.Models
{
    public class AddDoctor
    {
        [Key]
        public int DoctorID { get; set; }
        [Required(ErrorMessage = "Please Enter the FirstName")]
        [RegularExpression("^[a-zA-Z0-9]*$",ErrorMessage ="Special Characters not Allowed")]
        public string FirstName { get; set; }
        [Required(ErrorMessage = "Please Enter the LastName")]
        [RegularExpression("^[a-zA-Z0-9]*$", ErrorMessage = "Special Characters not Allowed")]
        public string LastName { get; set; }
        [Required(ErrorMessage = "Please select your Gender")]
        public string Sex { get; set; }
        [Required(ErrorMessage = "Please select your specialization")]
        public string Specialization { get; set; }
        [Required(ErrorMessage = "Please select your vistinghours")]
        public string VisitingHours { get; set; }
    }
}
