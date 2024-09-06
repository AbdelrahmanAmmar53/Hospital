﻿// <auto-generated />
using System;
using Hospital;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Hospital.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20240904203011_InitialSeed2")]
    partial class InitialSeed2
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "8.0.8");

            modelBuilder.Entity("Hospital.Modles.Appointment", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("AppoDate")
                        .HasColumnType("TEXT");

                    b.Property<int>("DoctorId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("PatientId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Purpose")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("DoctorId");

                    b.HasIndex("PatientId");

                    b.ToTable("Appointments");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            AppoDate = new DateTime(2024, 9, 11, 23, 30, 10, 55, DateTimeKind.Local).AddTicks(2978),
                            DoctorId = 1,
                            PatientId = 1,
                            Purpose = "Follow-up",
                            Status = "Confirmed"
                        },
                        new
                        {
                            Id = 2,
                            AppoDate = new DateTime(2024, 9, 14, 23, 30, 10, 55, DateTimeKind.Local).AddTicks(2985),
                            DoctorId = 2,
                            PatientId = 2,
                            Purpose = "Check-up",
                            Status = "Pending"
                        },
                        new
                        {
                            Id = 3,
                            AppoDate = new DateTime(2024, 9, 18, 23, 30, 10, 55, DateTimeKind.Local).AddTicks(2991),
                            DoctorId = 3,
                            PatientId = 3,
                            Purpose = "Physiotherapy",
                            Status = "Pending"
                        },
                        new
                        {
                            Id = 4,
                            AppoDate = new DateTime(2024, 9, 9, 23, 30, 10, 55, DateTimeKind.Local).AddTicks(2996),
                            DoctorId = 4,
                            PatientId = 4,
                            Purpose = "X-ray",
                            Status = "Confirmed"
                        },
                        new
                        {
                            Id = 5,
                            AppoDate = new DateTime(2024, 9, 7, 23, 30, 10, 55, DateTimeKind.Local).AddTicks(3001),
                            DoctorId = 5,
                            PatientId = 5,
                            Purpose = "Surgery consultation",
                            Status = "Confirmed"
                        });
                });

            modelBuilder.Entity("Hospital.Modles.Department", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Departments");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Description = "Heart-related treatments",
                            Name = "Cardiology"
                        },
                        new
                        {
                            Id = 2,
                            Description = "Brain and nervous system treatments",
                            Name = "Neurology"
                        },
                        new
                        {
                            Id = 3,
                            Description = "Musculoskeletal system treatments",
                            Name = "Orthopedics"
                        },
                        new
                        {
                            Id = 4,
                            Description = "Child and adolescent treatments",
                            Name = "Pediatrics"
                        });
                });

            modelBuilder.Entity("Hospital.Modles.Doctor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("DepartmentId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Specialization")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("YearsOfExp")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("DepartmentId");

                    b.ToTable("Doctors");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            DepartmentId = 1,
                            Email = "john.doe@example.com",
                            FirstName = "John",
                            LastName = "Doe",
                            PhoneNumber = "1234567890",
                            Specialization = "Cardiologist",
                            YearsOfExp = 10
                        },
                        new
                        {
                            Id = 2,
                            DepartmentId = 2,
                            Email = "jane.smith@example.com",
                            FirstName = "Jane",
                            LastName = "Smith",
                            PhoneNumber = "0987654321",
                            Specialization = "Neurologist",
                            YearsOfExp = 8
                        },
                        new
                        {
                            Id = 3,
                            DepartmentId = 3,
                            Email = "robert.williams@example.com",
                            FirstName = "Robert",
                            LastName = "Williams",
                            PhoneNumber = "3334445555",
                            Specialization = "Orthopedic Surgeon",
                            YearsOfExp = 12
                        },
                        new
                        {
                            Id = 4,
                            DepartmentId = 4,
                            Email = "emily.davis@example.com",
                            FirstName = "Emily",
                            LastName = "Davis",
                            PhoneNumber = "6667778888",
                            Specialization = "Pediatrician",
                            YearsOfExp = 7
                        },
                        new
                        {
                            Id = 5,
                            DepartmentId = 1,
                            Email = "michael.brown@example.com",
                            FirstName = "Michael",
                            LastName = "Brown",
                            PhoneNumber = "9998887777",
                            Specialization = "Cardiologist",
                            YearsOfExp = 15
                        });
                });

            modelBuilder.Entity("Hospital.Modles.MedicalRecord", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("DateCreat")
                        .HasColumnType("TEXT");

                    b.Property<string>("Diagnosis")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("DoctorId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Note")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("PatientId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("prescribedTreatment")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("DoctorId");

                    b.HasIndex("PatientId");

                    b.ToTable("MedicalRecords");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            DateCreat = new DateTime(2024, 9, 4, 23, 30, 10, 55, DateTimeKind.Local).AddTicks(2819),
                            Diagnosis = "Hypertension",
                            DoctorId = 1,
                            Note = "Regular check-up required",
                            PatientId = 1,
                            prescribedTreatment = "Medication"
                        },
                        new
                        {
                            Id = 2,
                            DateCreat = new DateTime(2024, 9, 4, 23, 30, 10, 55, DateTimeKind.Local).AddTicks(2829),
                            Diagnosis = "Migraine",
                            DoctorId = 2,
                            Note = "Monitor for improvements",
                            PatientId = 2,
                            prescribedTreatment = "Pain relievers"
                        },
                        new
                        {
                            Id = 3,
                            DateCreat = new DateTime(2024, 9, 4, 23, 30, 10, 55, DateTimeKind.Local).AddTicks(2834),
                            Diagnosis = "Fractured arm",
                            DoctorId = 3,
                            Note = "Follow-up in 2 weeks",
                            PatientId = 3,
                            prescribedTreatment = "Surgery and physiotherapy"
                        },
                        new
                        {
                            Id = 4,
                            DateCreat = new DateTime(2024, 9, 4, 23, 30, 10, 55, DateTimeKind.Local).AddTicks(2839),
                            Diagnosis = "Pneumonia",
                            DoctorId = 4,
                            Note = "Check chest X-ray in 1 week",
                            PatientId = 4,
                            prescribedTreatment = "Antibiotics and rest"
                        },
                        new
                        {
                            Id = 5,
                            DateCreat = new DateTime(2024, 9, 4, 23, 30, 10, 55, DateTimeKind.Local).AddTicks(2844),
                            Diagnosis = "Arrhythmia",
                            DoctorId = 5,
                            Note = "Surgery required",
                            PatientId = 5,
                            prescribedTreatment = "Pacemaker"
                        });
                });

            modelBuilder.Entity("Hospital.Modles.Patient", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("AdmissionDate")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("DateOfBirth")
                        .HasColumnType("TEXT");

                    b.Property<DateTime?>("DischargeDate")
                        .HasColumnType("TEXT");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Gender")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Patients");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Address = "123 Elm Street",
                            AdmissionDate = new DateTime(2024, 9, 4, 23, 30, 10, 55, DateTimeKind.Local).AddTicks(2660),
                            DateOfBirth = new DateTime(1980, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "alice.johnson@example.com",
                            FirstName = "Alice",
                            Gender = "Female",
                            LastName = "Johnson",
                            PhoneNumber = "1112223333"
                        },
                        new
                        {
                            Id = 2,
                            Address = "456 Maple Street",
                            AdmissionDate = new DateTime(2024, 9, 4, 23, 30, 10, 55, DateTimeKind.Local).AddTicks(2730),
                            DateOfBirth = new DateTime(1975, 5, 15, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "bob.brown@example.com",
                            FirstName = "Bob",
                            Gender = "Male",
                            LastName = "Brown",
                            PhoneNumber = "4445556666"
                        },
                        new
                        {
                            Id = 3,
                            Address = "789 Oak Avenue",
                            AdmissionDate = new DateTime(2024, 9, 4, 23, 30, 10, 55, DateTimeKind.Local).AddTicks(2737),
                            DateOfBirth = new DateTime(1990, 8, 20, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "charles.taylor@example.com",
                            FirstName = "Charles",
                            Gender = "Male",
                            LastName = "Taylor",
                            PhoneNumber = "7778889999"
                        },
                        new
                        {
                            Id = 4,
                            Address = "101 Pine Road",
                            AdmissionDate = new DateTime(2024, 9, 4, 23, 30, 10, 55, DateTimeKind.Local).AddTicks(2744),
                            DateOfBirth = new DateTime(1985, 3, 30, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "diana.evans@example.com",
                            FirstName = "Diana",
                            Gender = "Female",
                            LastName = "Evans",
                            PhoneNumber = "0001112222"
                        },
                        new
                        {
                            Id = 5,
                            Address = "202 Cedar Lane",
                            AdmissionDate = new DateTime(2024, 9, 4, 23, 30, 10, 55, DateTimeKind.Local).AddTicks(2750),
                            DateOfBirth = new DateTime(2000, 12, 5, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "edward.moore@example.com",
                            FirstName = "Edward",
                            Gender = "Male",
                            LastName = "Moore",
                            PhoneNumber = "3332221111"
                        });
                });

            modelBuilder.Entity("Hospital.Modles.Treatment", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("MedicalRecordId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("OutCome")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("TreatDate")
                        .HasColumnType("TEXT");

                    b.Property<string>("TypesOfTreatment")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("MedicalRecordId");

                    b.ToTable("Treatments");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            MedicalRecordId = 1,
                            OutCome = "Stabilized",
                            TreatDate = new DateTime(2024, 9, 4, 23, 30, 10, 55, DateTimeKind.Local).AddTicks(2900),
                            TypesOfTreatment = "Medication"
                        },
                        new
                        {
                            Id = 2,
                            MedicalRecordId = 2,
                            OutCome = "Improved",
                            TreatDate = new DateTime(2024, 9, 4, 23, 30, 10, 55, DateTimeKind.Local).AddTicks(2907),
                            TypesOfTreatment = "Pain relievers"
                        },
                        new
                        {
                            Id = 3,
                            MedicalRecordId = 3,
                            OutCome = "Successful",
                            TreatDate = new DateTime(2024, 9, 3, 23, 30, 10, 55, DateTimeKind.Local).AddTicks(2912),
                            TypesOfTreatment = "Surgery"
                        },
                        new
                        {
                            Id = 4,
                            MedicalRecordId = 4,
                            OutCome = "Recovering",
                            TreatDate = new DateTime(2024, 9, 1, 23, 30, 10, 55, DateTimeKind.Local).AddTicks(2919),
                            TypesOfTreatment = "Antibiotics"
                        },
                        new
                        {
                            Id = 5,
                            MedicalRecordId = 5,
                            OutCome = "Scheduled",
                            TreatDate = new DateTime(2024, 9, 6, 23, 30, 10, 55, DateTimeKind.Local).AddTicks(2924),
                            TypesOfTreatment = "Pacemaker Installation"
                        });
                });

            modelBuilder.Entity("Hospital.Modles.Appointment", b =>
                {
                    b.HasOne("Hospital.Modles.Doctor", "Doctor")
                        .WithMany("Appointments")
                        .HasForeignKey("DoctorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Hospital.Modles.Patient", "Patient")
                        .WithMany("Appointments")
                        .HasForeignKey("PatientId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Doctor");

                    b.Navigation("Patient");
                });

            modelBuilder.Entity("Hospital.Modles.Doctor", b =>
                {
                    b.HasOne("Hospital.Modles.Department", "Department")
                        .WithMany("Doctors")
                        .HasForeignKey("DepartmentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Department");
                });

            modelBuilder.Entity("Hospital.Modles.MedicalRecord", b =>
                {
                    b.HasOne("Hospital.Modles.Doctor", "Doctor")
                        .WithMany("MedicalRecords")
                        .HasForeignKey("DoctorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Hospital.Modles.Patient", "Patient")
                        .WithMany("MedicalRecords")
                        .HasForeignKey("PatientId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Doctor");

                    b.Navigation("Patient");
                });

            modelBuilder.Entity("Hospital.Modles.Treatment", b =>
                {
                    b.HasOne("Hospital.Modles.MedicalRecord", "MedicalRecord")
                        .WithMany("Treatments")
                        .HasForeignKey("MedicalRecordId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("MedicalRecord");
                });

            modelBuilder.Entity("Hospital.Modles.Department", b =>
                {
                    b.Navigation("Doctors");
                });

            modelBuilder.Entity("Hospital.Modles.Doctor", b =>
                {
                    b.Navigation("Appointments");

                    b.Navigation("MedicalRecords");
                });

            modelBuilder.Entity("Hospital.Modles.MedicalRecord", b =>
                {
                    b.Navigation("Treatments");
                });

            modelBuilder.Entity("Hospital.Modles.Patient", b =>
                {
                    b.Navigation("Appointments");

                    b.Navigation("MedicalRecords");
                });
#pragma warning restore 612, 618
        }
    }
}
