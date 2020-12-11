using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using HospitalMgmt.Models;

namespace HospitalMgmt.Data
{
    public class HospitalMgmtContext : DbContext
    {
        public HospitalMgmtContext (DbContextOptions<HospitalMgmtContext> options)
            : base(options)
        {
        }

        public DbSet<HospitalMgmt.Models.Appointments> Appointments { get; set; }

        public DbSet<HospitalMgmt.Models.PatientDetails> PatientDetails { get; set; }

        public DbSet<HospitalMgmt.Models.Doctor> Doctor { get; set; }

        public DbSet<HospitalMgmt.Models.Medicines> Medicines { get; set; }
    }
}
