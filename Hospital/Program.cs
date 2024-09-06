using Hospital.Modles;
using Microsoft.EntityFrameworkCore;

namespace Hospital
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //creat Patient
            var Patient = new Patient()
            {
                FirstName = "Abdo",
                LastName = "Ammar",
                Email = "marbdrhman2@gmail.com",
                PhoneNumber = "01056154864163",
                Address = "Alex",
                Gender = "Male",
                DateOfBirth = DateTime.Now,
                AdmissionDate = DateTime.Now,
            };
            var DbContext = new ApplicationDbContext();
            DbContext.Database.EnsureCreated();
            DbContext.Patients.Add(Patient);
            DbContext.SaveChanges();

            //Read
            DbContext.Patients.FirstOrDefault();
            Console.WriteLine(Patient.FirstName);

            //Update
            var AfterUp = DbContext.Patients.FirstOrDefault();
            if (AfterUp != null)
            {
                AfterUp.FirstName = "Ahmed";
            }
            DbContext.SaveChanges();

            //Delete
            DbContext.Patients.Remove(Patient);
            DbContext.SaveChanges();

            //Creat Doctor
            var Doctor = new Doctor()
            {
                FirstName = "Mohamed",
                LastName = "Ammar",
                Email = "Mohamed@gmail.com",
                PhoneNumber = "01056154864163",
                YearsOfExp = 5,
                Specialization = "Cardiologist",
                DepartmentId =1
            };
            var DbContext2 = new ApplicationDbContext();
            DbContext2.Database.EnsureCreated();
            DbContext2.Doctors.Add(Doctor);
            DbContext2.SaveChanges();

            //Read
            DbContext2.Doctors.FirstOrDefault();
            Console.WriteLine(Doctor.FirstName);

            //Update
            var AfterUp2 = DbContext2.Doctors.FirstOrDefault();
            if (AfterUp2 != null)
            {
                AfterUp2.FirstName = "Momen";
            }
            DbContext2.SaveChanges();

            //Delete
            DbContext2. Doctors.Remove(Doctor);
            DbContext2.SaveChanges();

            //Creat Department
            var Department = new Department()
            {
                Name = "Sugar",
                Description = "Its Important Department"
            };
            var DbContext3 = new ApplicationDbContext();
            DbContext3.Database.EnsureCreated();
            DbContext3.Departments.Add(Department);
            DbContext3.SaveChanges();

            //Read
            DbContext3.Departments.FirstOrDefault();
            Console.WriteLine(Department.Name);

            //Update
            var AfterUp3 = DbContext3.Departments.FirstOrDefault();
            if (AfterUp3 != null)
            {
                AfterUp3.Name = "The interior";
            }
            DbContext3.SaveChanges();

            //Delete
            DbContext3.Departments.Remove(Department);
            DbContext3.SaveChanges();

            //Creat MedicalRecords
            var medical = new MedicalRecord()
            {
                DateCreat = DateTime.Now,
                Diagnosis = "Hypertension",
                prescribedTreatment = "Medication",
                Note = "Regular check-up required",
                PatientId = 1,
                DoctorId = 1
            };
            var DbContext4 = new ApplicationDbContext();
            DbContext4.Database.EnsureCreated();
            DbContext4.MedicalRecords.Add(medical);
            DbContext4.SaveChanges();

            //Read
            DbContext4.MedicalRecords.FirstOrDefault();
            Console.WriteLine(medical.Note);

            //Update
            var AfterUp4 = DbContext4.MedicalRecords.FirstOrDefault();
            if (AfterUp4 != null)
            {
                AfterUp4.DoctorId = 4;
            }
            DbContext4.SaveChanges();

            //Delete
            DbContext4.MedicalRecords.Remove(medical);
            DbContext4.SaveChanges();

            //Creat Treatment
            var Treatment = new Treatment()
            {
                TreatDate = DateTime.Now,
                TypesOfTreatment = "Surgery",
                OutCome = "Successful",
                MedicalRecordId = 1
            };
            var DbContext5 = new ApplicationDbContext();
            DbContext5.Database.EnsureCreated();
            DbContext5.Treatments.Add(Treatment);
            DbContext5.SaveChanges();

            //Read
            DbContext5.Treatments.FirstOrDefault();
            Console.WriteLine(Treatment.OutCome);

            //Update
            var AfterUp5 = DbContext5.Treatments.FirstOrDefault();
            if (AfterUp5 != null)
            {
                AfterUp5.TreatDate = new DateTime(2024,7,4);
            }
            DbContext5.SaveChanges();

            //Delete
            DbContext5.Treatments.Remove(Treatment);
            DbContext5.SaveChanges();

            //Creat Appointment
            var Appointment = new Appointment()
            {
                AppoDate = DateTime.Now.AddDays(10),
                Purpose = "General Checkup",
                Status = "Scheduled",
                DoctorId = 1,
                PatientId = 1
            };
            var DbContext6 = new ApplicationDbContext();
            DbContext6.Database.EnsureCreated();
            DbContext6.Appointments.Add(Appointment);
            DbContext6.SaveChanges();

            //Read
            DbContext6.Appointments.FirstOrDefault();
            Console.WriteLine(Appointment.Status);

            //Update
            var AfterUp6 = DbContext6.Appointments.FirstOrDefault();
            if (AfterUp6 != null)
            {
                AfterUp6.Status = "Good";
            }
            DbContext6.SaveChanges();

            //Delete
            DbContext6.Appointments.Remove(Appointment);
            DbContext6.SaveChanges();

            var context = new ApplicationDbContext();
            var patientId = 1;
            var doctorsWhoTreatedPatient = context.MedicalRecords
                .Where(mr => mr.PatientId == patientId)
                .Select(mr => mr.Doctor)
                .Distinct()
                .ToList();

            foreach (var doctor in doctorsWhoTreatedPatient)
            {
                Console.WriteLine($"Doctor: {doctor.FirstName} {doctor.LastName} ({doctor.Specialization})");
            }

            var departmentId = 1;
            var oneMonthAgo = DateTime.Now.AddMonths(-1);
            var patientsTreatedInDepartment = context.MedicalRecords
                .Where(mr => mr.Doctor.DepartmentId == departmentId && mr.DateCreat >= oneMonthAgo)
                .Select(mr => mr.Patient)
                .Distinct()
                .ToList();

            foreach (var patient in patientsTreatedInDepartment)
            {
                Console.WriteLine($"Patient: {patient.FirstName} {patient.LastName}");
            }

            var commonDiagnoses = context.MedicalRecords
            .GroupBy(mr => mr.Diagnosis)
            .OrderByDescending(grp => grp.Count())
            .Select(grp => new { Diagnosis = grp.Key, Count = grp.Count() })
            .ToList();

            foreach (var diagnosis in commonDiagnoses)
            {
                Console.WriteLine($"Diagnosis: {diagnosis.Diagnosis}, Count: {diagnosis.Count}");
            }

            var nextWeek = DateTime.Now.AddDays(7);
            var appointmentsNextWeek = context.Appointments
                .Where(appt => appt.AppoDate <= nextWeek)
                .Select(appt => new
                {
                    PatientName = appt.Patient.FirstName + " " + appt.Patient.LastName,
                    DoctorName = appt.Doctor.FirstName + " " + appt.Doctor.LastName,
                    DoctorPhone = appt.Doctor.PhoneNumber
                })
                .ToList();

            foreach (var appt in appointmentsNextWeek)
            {
                Console.WriteLine($"Patient: {appt.PatientName}, Doctor: {appt.DoctorName}, Doctor Phone: {appt.DoctorPhone}");
            }
            //Reports
            var oneYearAgo = DateTime.Now.AddYears(-1);
            var patientsPerDepartment = context.MedicalRecords
                .Where(mr => mr.DateCreat >= oneYearAgo)
                .GroupBy(mr => mr.Doctor.Department)
                .Select(grp => new
                {
                    Department = grp.Key.Name,
                    PatientCount = grp.Select(mr => mr.Patient).Distinct().Count()
                })
                .ToList();

            foreach (var department in patientsPerDepartment)
            {
                Console.WriteLine($"Department: {department.Department}, Patients Treated: {department.PatientCount}");
            }

            var treatmentDurations = context.Treatments
                .GroupBy(t => t.TypesOfTreatment)
                .Select(group => new
                {
                    TreatmentType = group.Key,
                    AverageDuration = group.Average(t => (t.TreatDate - t.MedicalRecord.DateCreat).TotalMinutes),
                    Treatments = group.ToList()
                })
                .ToList();

            foreach (var treatment in treatmentDurations)
            {
                Console.WriteLine($"Treatment Type: {treatment.TreatmentType}, Avg Duration: {treatment.AverageDuration} minutes");

                // Identifying outliers (treatments that are far from the average)
                var outliers = treatment.Treatments
                    .Where(t => Math.Abs((t.TreatDate - t.MedicalRecord.DateCreat).TotalMinutes - treatment.AverageDuration) > 60) // Example threshold
                    .ToList();

                if (outliers.Any())
                {
                    Console.WriteLine("Outliers:");
                    foreach (var outlier in outliers)
                    {
                        Console.WriteLine($"Treatment Date: {outlier.TreatDate}, Duration: {(outlier.TreatDate - outlier.MedicalRecord.DateCreat).TotalMinutes} minutes");
                    }
                }
            }

            var topDoctors = context.MedicalRecords
            .GroupBy(mr => mr.Doctor)
            .OrderByDescending(grp => grp.Select(mr => mr.PatientId).Distinct().Count())
            .Take(5)
            .Select(grp => new
            {
              DoctorName = grp.Key.FirstName + " " + grp.Key.LastName,
              PatientCount = grp.Select(mr => mr.PatientId).Distinct().Count()
            }).ToList();

            foreach (var doctor in topDoctors)
            {
                Console.WriteLine($"Doctor: {doctor.DoctorName}, Patients Treated: {doctor.PatientCount}");
            }
        }
    }
}

