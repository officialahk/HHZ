using HHZ.Models;
using Microsoft.AspNet.Identity.EntityFramework;
using System.Data.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HHZ.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {

        public DbSet<Doctor> Doctors { get; set; }
        public DbSet<DoctorType> DoctorTypes { get; set; }
        public DbSet<DoctorQualification> PhysicianQualifications { get; set; }
        public DbSet<DoctorSpecialization> DoctorSpecializations { get; set; }
        public DbSet<DoctorExperience> DoctorExperiences { get; set; }
        public DbSet<Specialization> Specializations { get; set; }
        public DbSet<ClinicInfo> ClinicInfos { get; set; }
        public DbSet<ClinicTime> ClinicTimes { get; set; }
        public DbSet<Sign> Signs { get; set; }
        public DbSet<SignsValue> SignsValues { get; set; }
        public DbSet<Test> Tests { get; set; }
        public DbSet<Parameter> Parameters { get; set; }
        public DbSet<ParameterValues> ParameterValues { get; set; }
        public DbSet<Symptom> Symptoms { get; set; }
        public DbSet<SymptomMedicine> SymptomMedicines { get; set; }
        public DbSet<Patient> Patients { get; set; }
        public DbSet<PatientSign> PatientSigns { get; set; }
        public DbSet<PatientFamilyHistory> PatientFamilyHistories { get; set; }
        public DbSet<PatientPqrs> PatientPqrses { get; set; }
        public DbSet<PatientLabTest> PatientLabTests { get; set; }
        public DbSet<PatientReportDetail> PatientReportDetails { get; set; }
        public DbSet<PatientPastHistory> PatientPastHistories { get; set; }
        public DbSet<PatientSymptom> PatientSymptoms { get; set; }



        public ApplicationDbContext()
            : base("DefaultConnection", throwIfV1Schema: false)
        {
        }

        public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }




        protected override void OnModelCreating(DbModelBuilder modelBuilder)   //Fluent Api
        {

            modelBuilder.Properties<DateTime>()
                .Configure(c => c.HasColumnType("datetime2"));

            base.OnModelCreating(modelBuilder);
        }
    }

}