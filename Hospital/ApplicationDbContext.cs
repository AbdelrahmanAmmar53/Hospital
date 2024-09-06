using Hospital.Modles;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital
{
    internal class ApplicationDbContext:DbContext 
    {
        public DbSet<Patient> Patients { get; set; }
        public DbSet<Doctor> Doctors { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Appointment> Appointments { get; set; }
        public DbSet<MedicalRecord> MedicalRecords { get; set; }
        public DbSet<Treatment> Treatments { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source = Hospital.db");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Department>().HasData(
                new Department { Id = 1, Name = "Cardiology", Description = "Heart-related treatments" },
                new Department { Id = 2, Name = "Neurology", Description = "Brain and nervous system treatments" },
                new Department { Id = 3, Name = "Orthopedics", Description = "Musculoskeletal system treatments" },
                new Department { Id = 4, Name = "Pediatrics", Description = "Child and adolescent treatments" }
            );

            modelBuilder.Entity<Doctor>().HasData(
                new Doctor { Id = 1, FirstName = "John", LastName = "Doe", Specialization = "Cardiologist", YearsOfExp = 10, PhoneNumber = "1234567890", Email = "john.doe@example.com", DepartmentId = 1 },
                new Doctor { Id = 2, FirstName = "Jane", LastName = "Smith", Specialization = "Neurologist", YearsOfExp = 8, PhoneNumber = "0987654321", Email = "jane.smith@example.com", DepartmentId = 2 },
                new Doctor { Id = 3, FirstName = "Robert", LastName = "Williams", Specialization = "Orthopedic Surgeon", YearsOfExp = 12, PhoneNumber = "3334445555", Email = "robert.williams@example.com", DepartmentId = 3 },
                new Doctor { Id = 4, FirstName = "Emily", LastName = "Davis", Specialization = "Pediatrician", YearsOfExp = 7, PhoneNumber = "6667778888", Email = "emily.davis@example.com", DepartmentId = 4 },
                new Doctor { Id = 5, FirstName = "Michael", LastName = "Brown", Specialization = "Cardiologist", YearsOfExp = 15, PhoneNumber = "9998887777", Email = "michael.brown@example.com", DepartmentId = 1 });

            // Seed Patients
            modelBuilder.Entity<Patient>().HasData(
                new Patient { Id = 1, FirstName = "Alice", LastName = "Johnson", DateOfBirth = new DateTime(1980, 1, 1), Gender = "Female", Email = "alice.johnson@example.com", PhoneNumber = "1112223333", Address = "123 Elm Street", AdmissionDate = DateTime.Now },
                new Patient { Id = 2, FirstName = "Bob", LastName = "Brown", DateOfBirth = new DateTime(1975, 5, 15), Gender = "Male", Email = "bob.brown@example.com", PhoneNumber = "4445556666", Address = "456 Maple Street", AdmissionDate = DateTime.Now },
                new Patient { Id = 3, FirstName = "Charles", LastName = "Taylor", DateOfBirth = new DateTime(1990, 8, 20), Gender = "Male", Email = "charles.taylor@example.com", PhoneNumber = "7778889999", Address = "789 Oak Avenue", AdmissionDate = DateTime.Now },
                new Patient { Id = 4, FirstName = "Diana", LastName = "Evans", DateOfBirth = new DateTime(1985, 3, 30), Gender = "Female", Email = "diana.evans@example.com", PhoneNumber = "0001112222", Address = "101 Pine Road", AdmissionDate = DateTime.Now },
                new Patient { Id = 5, FirstName = "Edward", LastName = "Moore", DateOfBirth = new DateTime(2000, 12, 5), Gender = "Male", Email = "edward.moore@example.com", PhoneNumber = "3332221111", Address = "202 Cedar Lane", AdmissionDate = DateTime.Now }
                );

            // Seed Medical Records
            modelBuilder.Entity<MedicalRecord>().HasData(
                new MedicalRecord { Id = 1, DateCreat = DateTime.Now, Diagnosis = "Hypertension", prescribedTreatment = "Medication", Note = "Regular check-up required", PatientId = 1, DoctorId = 1 },
                new MedicalRecord { Id = 2, DateCreat = DateTime.Now, Diagnosis = "Migraine", prescribedTreatment = "Pain relievers", Note = "Monitor for improvements", PatientId = 2, DoctorId = 2 },
                new MedicalRecord { Id = 3, DateCreat = DateTime.Now, Diagnosis = "Fractured arm", prescribedTreatment = "Surgery and physiotherapy", Note = "Follow-up in 2 weeks", PatientId = 3, DoctorId = 3 },
                new MedicalRecord { Id = 4, DateCreat = DateTime.Now, Diagnosis = "Pneumonia", prescribedTreatment = "Antibiotics and rest", Note = "Check chest X-ray in 1 week", PatientId = 4, DoctorId = 4 },
                new MedicalRecord { Id = 5, DateCreat = DateTime.Now, Diagnosis = "Arrhythmia", prescribedTreatment = "Pacemaker", Note = "Surgery required", PatientId = 5, DoctorId = 5 }
                );
            // Seed Treatments
            modelBuilder.Entity<Treatment>().HasData(
                new Treatment { Id = 1, TreatDate = DateTime.Now, TypesOfTreatment = "Medication", OutCome = "Stabilized", MedicalRecordId = 1 },
                new Treatment { Id = 2, TreatDate = DateTime.Now, TypesOfTreatment = "Pain relievers", OutCome = "Improved", MedicalRecordId = 2 },
                new Treatment { Id = 3, TreatDate = DateTime.Now.AddDays(-1), TypesOfTreatment = "Surgery", OutCome = "Successful", MedicalRecordId = 3 },
                new Treatment { Id = 4, TreatDate = DateTime.Now.AddDays(-3), TypesOfTreatment = "Antibiotics", OutCome = "Recovering", MedicalRecordId = 4 },
                new Treatment { Id = 5, TreatDate = DateTime.Now.AddDays(2), TypesOfTreatment = "Pacemaker Installation", OutCome = "Scheduled", MedicalRecordId = 5 }
                );
            // Seed Appointments
            modelBuilder.Entity<Appointment>().HasData(
                new Appointment { Id = 1, AppoDate = DateTime.Now.AddDays(7), Purpose = "Follow-up", Status = "Confirmed", DoctorId = 1, PatientId = 1 },
                new Appointment { Id = 2, AppoDate = DateTime.Now.AddDays(10), Purpose = "Check-up", Status = "Pending", DoctorId = 2, PatientId = 2 },
                new Appointment { Id = 3, AppoDate = DateTime.Now.AddDays(14), Purpose = "Physiotherapy", Status = "Pending", DoctorId = 3, PatientId = 3 },
                new Appointment { Id = 4, AppoDate = DateTime.Now.AddDays(5), Purpose = "X-ray", Status = "Confirmed", DoctorId = 4, PatientId = 4 },
                new Appointment { Id = 5, AppoDate = DateTime.Now.AddDays(3), Purpose = "Surgery consultation", Status = "Confirmed", DoctorId = 5, PatientId = 5 }
                );
        }

    }
}
