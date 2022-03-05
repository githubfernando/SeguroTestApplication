using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplicationSeguros.Models
{
    public class Customer
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [StringLength(50)]
        [Display(Name = "Identification Number")]
        public string Identification {get; set;}
        [Required]
        [StringLength(50)]
        [Display(Name = "First name and last name")]
        public string Name { get; set; }

    }
}
