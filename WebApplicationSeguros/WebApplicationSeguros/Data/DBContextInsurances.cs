using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WebApplicationSeguros.Models;

namespace WebApplicationSeguros.Data
{
    public class DBContextInsurances : DbContext
    {
        public DBContextInsurances(DbContextOptions<DBContextInsurances> options) : base (options)
        { 
        
        }
        public DbSet<InsurancePolicy> InsurancePolicies { get; set; }
        public DbSet<CoverType> CoverTypes { get; set; }
    }
}
