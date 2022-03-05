﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplicationSeguros.Models
{
    public class CoverType
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [StringLength(50)]
        [Display(Name = "Name Cover Type")]
        public string Name { get; set; }

    }
}
