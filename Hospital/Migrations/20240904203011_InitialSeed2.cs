using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Hospital.Migrations
{
    /// <inheritdoc />
    public partial class InitialSeed2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "MedicalId",
                table: "Treatments");

            migrationBuilder.DropColumn(
                name: "DocId",
                table: "MedicalRecords");

            migrationBuilder.DropColumn(
                name: "DepId",
                table: "Doctors");

            migrationBuilder.DropColumn(
                name: "DocId",
                table: "Appointments");

            migrationBuilder.RenameColumn(
                name: "note",
                table: "MedicalRecords",
                newName: "Note");

            migrationBuilder.RenameColumn(
                name: "diagnosis",
                table: "MedicalRecords",
                newName: "Diagnosis");

            migrationBuilder.RenameColumn(
                name: "Pirpose",
                table: "Appointments",
                newName: "Purpose");

            migrationBuilder.AlterColumn<string>(
                name: "OutCome",
                table: "Treatments",
                type: "TEXT",
                nullable: false,
                oldClrType: typeof(double),
                oldType: "REAL");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DischargeDate",
                table: "Patients",
                type: "TEXT",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "TEXT");

            migrationBuilder.InsertData(
                table: "Departments",
                columns: new[] { "Id", "Description", "Name" },
                values: new object[,]
                {
                    { 1, "Heart-related treatments", "Cardiology" },
                    { 2, "Brain and nervous system treatments", "Neurology" },
                    { 3, "Musculoskeletal system treatments", "Orthopedics" },
                    { 4, "Child and adolescent treatments", "Pediatrics" }
                });

            migrationBuilder.InsertData(
                table: "Patients",
                columns: new[] { "Id", "Address", "AdmissionDate", "DateOfBirth", "DischargeDate", "Email", "FirstName", "Gender", "LastName", "PhoneNumber" },
                values: new object[,]
                {
                    { 1, "123 Elm Street", new DateTime(2024, 9, 4, 23, 30, 10, 55, DateTimeKind.Local).AddTicks(2660), new DateTime(1980, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "alice.johnson@example.com", "Alice", "Female", "Johnson", "1112223333" },
                    { 2, "456 Maple Street", new DateTime(2024, 9, 4, 23, 30, 10, 55, DateTimeKind.Local).AddTicks(2730), new DateTime(1975, 5, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "bob.brown@example.com", "Bob", "Male", "Brown", "4445556666" },
                    { 3, "789 Oak Avenue", new DateTime(2024, 9, 4, 23, 30, 10, 55, DateTimeKind.Local).AddTicks(2737), new DateTime(1990, 8, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "charles.taylor@example.com", "Charles", "Male", "Taylor", "7778889999" },
                    { 4, "101 Pine Road", new DateTime(2024, 9, 4, 23, 30, 10, 55, DateTimeKind.Local).AddTicks(2744), new DateTime(1985, 3, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "diana.evans@example.com", "Diana", "Female", "Evans", "0001112222" },
                    { 5, "202 Cedar Lane", new DateTime(2024, 9, 4, 23, 30, 10, 55, DateTimeKind.Local).AddTicks(2750), new DateTime(2000, 12, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "edward.moore@example.com", "Edward", "Male", "Moore", "3332221111" }
                });

            migrationBuilder.InsertData(
                table: "Doctors",
                columns: new[] { "Id", "DepartmentId", "Email", "FirstName", "LastName", "PhoneNumber", "Specialization", "YearsOfExp" },
                values: new object[,]
                {
                    { 1, 1, "john.doe@example.com", "John", "Doe", "1234567890", "Cardiologist", 10 },
                    { 2, 2, "jane.smith@example.com", "Jane", "Smith", "0987654321", "Neurologist", 8 },
                    { 3, 3, "robert.williams@example.com", "Robert", "Williams", "3334445555", "Orthopedic Surgeon", 12 },
                    { 4, 4, "emily.davis@example.com", "Emily", "Davis", "6667778888", "Pediatrician", 7 },
                    { 5, 1, "michael.brown@example.com", "Michael", "Brown", "9998887777", "Cardiologist", 15 }
                });

            migrationBuilder.InsertData(
                table: "Appointments",
                columns: new[] { "Id", "AppoDate", "DoctorId", "PatientId", "Purpose", "Status" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 9, 11, 23, 30, 10, 55, DateTimeKind.Local).AddTicks(2978), 1, 1, "Follow-up", "Confirmed" },
                    { 2, new DateTime(2024, 9, 14, 23, 30, 10, 55, DateTimeKind.Local).AddTicks(2985), 2, 2, "Check-up", "Pending" },
                    { 3, new DateTime(2024, 9, 18, 23, 30, 10, 55, DateTimeKind.Local).AddTicks(2991), 3, 3, "Physiotherapy", "Pending" },
                    { 4, new DateTime(2024, 9, 9, 23, 30, 10, 55, DateTimeKind.Local).AddTicks(2996), 4, 4, "X-ray", "Confirmed" },
                    { 5, new DateTime(2024, 9, 7, 23, 30, 10, 55, DateTimeKind.Local).AddTicks(3001), 5, 5, "Surgery consultation", "Confirmed" }
                });

            migrationBuilder.InsertData(
                table: "MedicalRecords",
                columns: new[] { "Id", "DateCreat", "Diagnosis", "DoctorId", "Note", "PatientId", "prescribedTreatment" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 9, 4, 23, 30, 10, 55, DateTimeKind.Local).AddTicks(2819), "Hypertension", 1, "Regular check-up required", 1, "Medication" },
                    { 2, new DateTime(2024, 9, 4, 23, 30, 10, 55, DateTimeKind.Local).AddTicks(2829), "Migraine", 2, "Monitor for improvements", 2, "Pain relievers" },
                    { 3, new DateTime(2024, 9, 4, 23, 30, 10, 55, DateTimeKind.Local).AddTicks(2834), "Fractured arm", 3, "Follow-up in 2 weeks", 3, "Surgery and physiotherapy" },
                    { 4, new DateTime(2024, 9, 4, 23, 30, 10, 55, DateTimeKind.Local).AddTicks(2839), "Pneumonia", 4, "Check chest X-ray in 1 week", 4, "Antibiotics and rest" },
                    { 5, new DateTime(2024, 9, 4, 23, 30, 10, 55, DateTimeKind.Local).AddTicks(2844), "Arrhythmia", 5, "Surgery required", 5, "Pacemaker" }
                });

            migrationBuilder.InsertData(
                table: "Treatments",
                columns: new[] { "Id", "MedicalRecordId", "OutCome", "TreatDate", "TypesOfTreatment" },
                values: new object[,]
                {
                    { 1, 1, "Stabilized", new DateTime(2024, 9, 4, 23, 30, 10, 55, DateTimeKind.Local).AddTicks(2900), "Medication" },
                    { 2, 2, "Improved", new DateTime(2024, 9, 4, 23, 30, 10, 55, DateTimeKind.Local).AddTicks(2907), "Pain relievers" },
                    { 3, 3, "Successful", new DateTime(2024, 9, 3, 23, 30, 10, 55, DateTimeKind.Local).AddTicks(2912), "Surgery" },
                    { 4, 4, "Recovering", new DateTime(2024, 9, 1, 23, 30, 10, 55, DateTimeKind.Local).AddTicks(2919), "Antibiotics" },
                    { 5, 5, "Scheduled", new DateTime(2024, 9, 6, 23, 30, 10, 55, DateTimeKind.Local).AddTicks(2924), "Pacemaker Installation" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Treatments",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Treatments",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Treatments",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Treatments",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Treatments",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "MedicalRecords",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "MedicalRecords",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "MedicalRecords",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "MedicalRecords",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "MedicalRecords",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.RenameColumn(
                name: "Note",
                table: "MedicalRecords",
                newName: "note");

            migrationBuilder.RenameColumn(
                name: "Diagnosis",
                table: "MedicalRecords",
                newName: "diagnosis");

            migrationBuilder.RenameColumn(
                name: "Purpose",
                table: "Appointments",
                newName: "Pirpose");

            migrationBuilder.AlterColumn<double>(
                name: "OutCome",
                table: "Treatments",
                type: "REAL",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "TEXT");

            migrationBuilder.AddColumn<int>(
                name: "MedicalId",
                table: "Treatments",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<DateTime>(
                name: "DischargeDate",
                table: "Patients",
                type: "TEXT",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "TEXT",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "DocId",
                table: "MedicalRecords",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "DepId",
                table: "Doctors",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "DocId",
                table: "Appointments",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);
        }
    }
}
