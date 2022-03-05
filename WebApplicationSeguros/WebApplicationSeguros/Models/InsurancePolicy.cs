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
        [StringLength(20)]
        [Display(Name = "Identification Customer")]
        public string IdentificationNumber {get; set;}

        [Required]
        [StringLength(100)]
        [Display(Name = "Name Policy")]
        public string Name { get; set; }

        [Required]
        [StringLength(100)]
        [Display(Name = "Policy description")]
        public string Description { get; set; }

        [Required]
        [DataType(DataType.Text)]
        [Display(Name = "Cover Type")]
        public string NameCoverType { get; set; }
        [Required]
        [DataType(DataType.Currency)]
        [Display(Name = "Cover percent")]
        public decimal CoverPercent { get; set; }

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
        public string NameTypeRisk { get; set; }

        [Required]
        [Display(Name = "Insurance Active")]
        public bool Active { get; set; }

        public CoverType CoverType { get; set; }
        public TypeRisk TypeRisk { get; set; }
        public Customer Customer { get; set; }

        //public InsurancePolicy()
        //{
        //    CoverType = new CoverType();
        //    TypeRisk = new TypeRisk();
        //    Customer = new Customer();
        //    Active = true;
        //}

    }
}
