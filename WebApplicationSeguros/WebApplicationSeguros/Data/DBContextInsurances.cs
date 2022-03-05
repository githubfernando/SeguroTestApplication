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
        public DbSet<CoverType> converTypes { get; set; }
    }
}
