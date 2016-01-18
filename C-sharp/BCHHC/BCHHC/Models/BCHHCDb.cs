using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace BCHHC.Models
{
    public class BCHHCDb : DbContext
    {
        public DbSet<Patient> Patients { get; set; }
        public DbSet<Measurement> Measurements { get; set; }

    }
}