using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using Project.Models;

namespace Project.Models
{
    public class AddApointment
    {
        [Key]
        [Required(ErrorMessage ="please fill this field")]
        public int PatientID { get; set; }
        [Required(ErrorMessage ="please fill this field")]
        public string Sepcialization { get; set; }
        [Required(ErrorMessage = "please fill this field")]
        public string Doctor { get; set; }
        [Required(ErrorMessage = "please fill this field")]
        public string VisitDate { get; set; }
        [Required(ErrorMessage = "please fill this field")]
        public string AppointmentTime { get; set; }
    }
}
