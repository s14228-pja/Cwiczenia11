using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CodeFirs.Models
{
    public class MyDBContext : DbContext
    {
        public DbSet<Medicament> Medicament { get; set; }
        public DbSet<Prescription> Prescription { get; set; }
        public DbSet<Prescription_Medicament> Prescription_Medicament { get; set; }
        public DbSet<Doctor> Doctor { get; set; }
        public DbSet<Patient> Patient { get; set; }

        public MyDBContext() { }

        public MyDBContext(DbContextOptions options)
        : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Prescription_Medicament>()
                         .HasKey(e => new { e.IdMedicament, e.IdPrescription });

            var dictDoctor = new List<Doctor>();
            dictDoctor.Add(new Doctor {IdDoctor = 123, FirstName = "Jan", LastName = "Okoń" });
            dictDoctor.Add(new Doctor { IdDoctor = 124, FirstName = "Adam", LastName = "Biwak" });

            modelBuilder.Entity<Doctor>()
                        .HasData(dictDoctor);

        }
    }
}