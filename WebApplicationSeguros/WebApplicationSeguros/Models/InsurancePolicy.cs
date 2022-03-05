using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace WebApplicationSeguros.Models
{
    public class InsurancePolicy
    {
        [Key]
        public int id { get; set; }

        [Required]
        [StringLength(100)]
        [Display(Name = "Name")]
        public string Name { get; set; }

        [Required]
        [StringLength(100)]
        [Display(Name = "Description")]
        public string Description { get; set; }

        [Required]
        [Display(Name = "Cover Type")]
        public CoverType CoverType { get; set; }

        [Required]
        [DataType(DataType.DateTime)]
        [Display(Name = "Start Date Police Validity")]
        public DateTime StartDatePoliceValidity { get; set; }

        [Required]
        [Display(Name = "Coverage Period")]
        public int CoveragePeriod { get; set; }

        [Required]
        [DataType(DataType.Currency)]
        [Display(Name = "Policy Price")]
        public decimal PolicyPrice { get; set; }

        [Required]
        [DataType(DataType.Currency)]
        [Display(Name = "Type Risk")]
        public string TypeRisk { get; set; }

        public InsurancePolicy()
        {
            CoverType = new CoverType();
        }

    }
}
