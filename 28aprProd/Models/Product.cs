using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace ProdEF.Models
{
    public class Product
    {
        [Key]
        [Required]
        public int ProdID { get; set; }
        public string Prodname { get; set; }
        public DateTime Manfdate { get; set; }
    }
}
