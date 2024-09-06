using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Hospital.Migrations
{
    /// <inheritdoc />
    public partial class AfterCrud : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 1,
                column: "AppoDate",
                value: new DateTime(2024, 9, 13, 1, 27, 9, 681, DateTimeKind.Local).AddTicks(6879));

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 2,
                column: "AppoDate",
                value: new DateTime(2024, 9, 16, 1, 27, 9, 681, DateTimeKind.Local).AddTicks(6887));

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 3,
                column: "AppoDate",
                value: new DateTime(2024, 9, 20, 1, 27, 9, 681, DateTimeKind.Local).AddTicks(6893));

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 4,
                column: "AppoDate",
                value: new DateTime(2024, 9, 11, 1, 27, 9, 681, DateTimeKind.Local).AddTicks(6898));

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 5,
                column: "AppoDate",
                value: new DateTime(2024, 9, 9, 1, 27, 9, 681, DateTimeKind.Local).AddTicks(6903));

            migrationBuilder.UpdateData(
                table: "MedicalRecords",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreat",
                value: new DateTime(2024, 9, 6, 1, 27, 9, 681, DateTimeKind.Local).AddTicks(6732));

            migrationBuilder.UpdateData(
                table: "MedicalRecords",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreat",
                value: new DateTime(2024, 9, 6, 1, 27, 9, 681, DateTimeKind.Local).AddTicks(6744));

            migrationBuilder.UpdateData(
                table: "MedicalRecords",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreat",
                value: new DateTime(2024, 9, 6, 1, 27, 9, 681, DateTimeKind.Local).AddTicks(6749));

            migrationBuilder.UpdateData(
                table: "MedicalRecords",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateCreat",
                value: new DateTime(2024, 9, 6, 1, 27, 9, 681, DateTimeKind.Local).AddTicks(6754));

            migrationBuilder.UpdateData(
                table: "MedicalRecords",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateCreat",
                value: new DateTime(2024, 9, 6, 1, 27, 9, 681, DateTimeKind.Local).AddTicks(6759));

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 1,
                column: "AdmissionDate",
                value: new DateTime(2024, 9, 6, 1, 27, 9, 681, DateTimeKind.Local).AddTicks(6590));

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 2,
                column: "AdmissionDate",
                value: new DateTime(2024, 9, 6, 1, 27, 9, 681, DateTimeKind.Local).AddTicks(6657));

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 3,
                column: "AdmissionDate",
                value: new DateTime(2024, 9, 6, 1, 27, 9, 681, DateTimeKind.Local).AddTicks(6665));

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 4,
                column: "AdmissionDate",
                value: new DateTime(2024, 9, 6, 1, 27, 9, 681, DateTimeKind.Local).AddTicks(6671));

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 5,
                column: "AdmissionDate",
                value: new DateTime(2024, 9, 6, 1, 27, 9, 681, DateTimeKind.Local).AddTicks(6676));

            migrationBuilder.UpdateData(
                table: "Treatments",
                keyColumn: "Id",
                keyValue: 1,
                column: "TreatDate",
                value: new DateTime(2024, 9, 6, 1, 27, 9, 681, DateTimeKind.Local).AddTicks(6806));

            migrationBuilder.UpdateData(
                table: "Treatments",
                keyColumn: "Id",
                keyValue: 2,
                column: "TreatDate",
                value: new DateTime(2024, 9, 6, 1, 27, 9, 681, DateTimeKind.Local).AddTicks(6813));

            migrationBuilder.UpdateData(
                table: "Treatments",
                keyColumn: "Id",
                keyValue: 3,
                column: "TreatDate",
                value: new DateTime(2024, 9, 5, 1, 27, 9, 681, DateTimeKind.Local).AddTicks(6819));

            migrationBuilder.UpdateData(
                table: "Treatments",
                keyColumn: "Id",
                keyValue: 4,
                column: "TreatDate",
                value: new DateTime(2024, 9, 3, 1, 27, 9, 681, DateTimeKind.Local).AddTicks(6826));

            migrationBuilder.UpdateData(
                table: "Treatments",
                keyColumn: "Id",
                keyValue: 5,
                column: "TreatDate",
                value: new DateTime(2024, 9, 8, 1, 27, 9, 681, DateTimeKind.Local).AddTicks(6833));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 1,
                column: "AppoDate",
                value: new DateTime(2024, 9, 11, 23, 30, 10, 55, DateTimeKind.Local).AddTicks(2978));

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 2,
                column: "AppoDate",
                value: new DateTime(2024, 9, 14, 23, 30, 10, 55, DateTimeKind.Local).AddTicks(2985));

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 3,
                column: "AppoDate",
                value: new DateTime(2024, 9, 18, 23, 30, 10, 55, DateTimeKind.Local).AddTicks(2991));

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 4,
                column: "AppoDate",
                value: new DateTime(2024, 9, 9, 23, 30, 10, 55, DateTimeKind.Local).AddTicks(2996));

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 5,
                column: "AppoDate",
                value: new DateTime(2024, 9, 7, 23, 30, 10, 55, DateTimeKind.Local).AddTicks(3001));

            migrationBuilder.UpdateData(
                table: "MedicalRecords",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreat",
                value: new DateTime(2024, 9, 4, 23, 30, 10, 55, DateTimeKind.Local).AddTicks(2819));

            migrationBuilder.UpdateData(
                table: "MedicalRecords",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreat",
                value: new DateTime(2024, 9, 4, 23, 30, 10, 55, DateTimeKind.Local).AddTicks(2829));

            migrationBuilder.UpdateData(
                table: "MedicalRecords",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreat",
                value: new DateTime(2024, 9, 4, 23, 30, 10, 55, DateTimeKind.Local).AddTicks(2834));

            migrationBuilder.UpdateData(
                table: "MedicalRecords",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateCreat",
                value: new DateTime(2024, 9, 4, 23, 30, 10, 55, DateTimeKind.Local).AddTicks(2839));

            migrationBuilder.UpdateData(
                table: "MedicalRecords",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateCreat",
                value: new DateTime(2024, 9, 4, 23, 30, 10, 55, DateTimeKind.Local).AddTicks(2844));

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 1,
                column: "AdmissionDate",
                value: new DateTime(2024, 9, 4, 23, 30, 10, 55, DateTimeKind.Local).AddTicks(2660));

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 2,
                column: "AdmissionDate",
                value: new DateTime(2024, 9, 4, 23, 30, 10, 55, DateTimeKind.Local).AddTicks(2730));

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 3,
                column: "AdmissionDate",
                value: new DateTime(2024, 9, 4, 23, 30, 10, 55, DateTimeKind.Local).AddTicks(2737));

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 4,
                column: "AdmissionDate",
                value: new DateTime(2024, 9, 4, 23, 30, 10, 55, DateTimeKind.Local).AddTicks(2744));

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 5,
                column: "AdmissionDate",
                value: new DateTime(2024, 9, 4, 23, 30, 10, 55, DateTimeKind.Local).AddTicks(2750));

            migrationBuilder.UpdateData(
                table: "Treatments",
                keyColumn: "Id",
                keyValue: 1,
                column: "TreatDate",
                value: new DateTime(2024, 9, 4, 23, 30, 10, 55, DateTimeKind.Local).AddTicks(2900));

            migrationBuilder.UpdateData(
                table: "Treatments",
                keyColumn: "Id",
                keyValue: 2,
                column: "TreatDate",
                value: new DateTime(2024, 9, 4, 23, 30, 10, 55, DateTimeKind.Local).AddTicks(2907));

            migrationBuilder.UpdateData(
                table: "Treatments",
                keyColumn: "Id",
                keyValue: 3,
                column: "TreatDate",
                value: new DateTime(2024, 9, 3, 23, 30, 10, 55, DateTimeKind.Local).AddTicks(2912));

            migrationBuilder.UpdateData(
                table: "Treatments",
                keyColumn: "Id",
                keyValue: 4,
                column: "TreatDate",
                value: new DateTime(2024, 9, 1, 23, 30, 10, 55, DateTimeKind.Local).AddTicks(2919));

            migrationBuilder.UpdateData(
                table: "Treatments",
                keyColumn: "Id",
                keyValue: 5,
                column: "TreatDate",
                value: new DateTime(2024, 9, 6, 23, 30, 10, 55, DateTimeKind.Local).AddTicks(2924));
        }
    }
}
