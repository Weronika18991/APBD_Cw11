using System;
using System.Collections.Generic;
using Cw11.Configurations;
using Microsoft.EntityFrameworkCore;

namespace Cw11.Models
{
    public class ClinicDbContext: DbContext
    {
        public DbSet<Doctor> Doctor { get; set; }
        public DbSet<Patient> Patient { get; set; }
        public DbSet<Prescription> Prescription { get; set; }
        public DbSet<Medicament> Medicament { get; set; }
        public DbSet<PrescriptionMedicament> Prescription_Medicament { get; set; }

        public ClinicDbContext(){}
        public ClinicDbContext(DbContextOptions options)
            : base(options)
        {
            
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ApplyConfiguration(new DoctorEFConfiguration());
            modelBuilder.ApplyConfiguration(new PatientEFConfiguration());
            modelBuilder.ApplyConfiguration(new MedicamentEFConfiguration());
            modelBuilder.ApplyConfiguration(new PrescriptionEFConfiguration());
            modelBuilder.ApplyConfiguration(new PrescriptionMedicamentEFConfiguration());
            SeedData(modelBuilder);
        }
        
        protected void SeedData(ModelBuilder modelBuilder)
        {
            var doctors = new List<Doctor>();
            doctors.Add(new Doctor()
            {
                IdDoctor = 1,
                FirstName = "Jan",
                LastName = "Kowalski",
                Email = "xxx@gmail.com"
            });
            doctors.Add(new Doctor()
            {
                IdDoctor = 2,
                FirstName = "Ala",
                LastName = "Nowak",
                Email = "yyy@gmail.com"
            });
            modelBuilder.Entity<Doctor>().HasData(doctors);
            
            var patients= new List<Patient>();
            patients.Add(new Patient()
            {
                IdPatient = 1,
                FirstName = "Monika",
                LastName = "Nowakowska",
                Birthdate = Convert.ToDateTime("21.01.1998")
            });
            patients.Add(new Patient()
            {
                IdPatient = 2,
                FirstName = "Tomasz",
                LastName = "Maliszewski",
                Birthdate = Convert.ToDateTime("03.08.1980")
            });
            modelBuilder.Entity<Patient>().HasData(patients);
            
            var medicaments = new List<Medicament>();
            medicaments.Add(new Medicament()
            {
                IdMedicament = 1,
                Name = "Acerin",
                Description = "Lorem...",
                Type = "Płyn"
            });
            medicaments.Add(new Medicament()
            {
                IdMedicament = 2,
                Name = "Xanax",
                Description = "Lorem ipsum...",
                Type = "Depression"
            });
            modelBuilder.Entity<Medicament>().HasData(medicaments);
            
            var prescriptions = new List<Prescription>();
            prescriptions.Add(new Prescription()
            {
                IdPrescription = 1,
                Date = Convert.ToDateTime("01.01.2020"),
                DueDate = Convert.ToDateTime("01.11.2020"),
                IdPatient = 1,
                IdDoctor = 1
            });
            prescriptions.Add(new Prescription()
            {
                IdPrescription = 2,
                Date = Convert.ToDateTime("01.04.2020"),
                DueDate = Convert.ToDateTime("01.12.2020"),
                IdPatient = 2,
                IdDoctor = 2
            });
            modelBuilder.Entity<Prescription>().HasData(prescriptions);
            
            var prescriptions_medicaments = new List<PrescriptionMedicament>();
            prescriptions_medicaments.Add(new PrescriptionMedicament()
            {
                IdMedicament = 1,
                IdPrescription = 1,
                Dose = 1,
                Details = "Once a week"
            });
            modelBuilder.Entity<PrescriptionMedicament>().HasData(prescriptions_medicaments);
            


        }

        
    }
}