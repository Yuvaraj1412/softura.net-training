using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Project.Models
{
    public class login
    {
            [Key]
            [Required(ErrorMessage = "Please Enter the UserName")]
            //[RegularExpression("^[a-zA-Z0-9]*$",ErrorMessage ="special characters not allowed")]
            public string UserName { get; set; }
            public string FirstName { get; set; }
            public string LastName { get; set; }
            [Required]
            public string Password { get; set; }
        
    }
}
