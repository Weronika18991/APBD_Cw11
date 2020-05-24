using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Cw11.Migrations
{
    public partial class AddData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Doctor",
                columns: new[] { "IdDoctor", "Email", "FirstName", "LastName" },
                values: new object[,]
                {
                    { 1, "xxx@gmail.com", "Jan", "Kowalski" },
                    { 2, "yyy@gmail.com", "Ala", "Nowak" }
                });

            migrationBuilder.InsertData(
                table: "Medicament",
                columns: new[] { "IdMedicament", "Description", "Name", "Type" },
                values: new object[,]
                {
                    { 1, "Lorem...", "Acerin", "Płyn" },
                    { 2, "Lorem ipsum...", "Xanax", "Depression" }
                });

            migrationBuilder.InsertData(
                table: "Patient",
                columns: new[] { "IdPatient", "Birthdate", "FirstName", "LastName" },
                values: new object[,]
                {
                    { 1, new DateTime(1998, 1, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "Monika", "Nowakowska" },
                    { 2, new DateTime(1980, 8, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Tomasz", "Maliszewski" }
                });

            migrationBuilder.InsertData(
                table: "Prescription",
                columns: new[] { "IdPrescription", "Date", "DueDate", "IdDoctor", "IdPatient" },
                values: new object[] { 1, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 11, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 1 });

            migrationBuilder.InsertData(
                table: "Prescription",
                columns: new[] { "IdPrescription", "Date", "DueDate", "IdDoctor", "IdPatient" },
                values: new object[] { 2, new DateTime(2020, 4, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 2 });

            migrationBuilder.InsertData(
                table: "Prescription_Medicament",
                columns: new[] { "IdPrescription", "IdMedicament", "Details", "Dose" },
                values: new object[] { 1, 1, "Once a week", 1 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Medicament",
                keyColumn: "IdMedicament",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Prescription",
                keyColumn: "IdPrescription",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Prescription_Medicament",
                keyColumns: new[] { "IdPrescription", "IdMedicament" },
                keyValues: new object[] { 1, 1 });

            migrationBuilder.DeleteData(
                table: "Doctor",
                keyColumn: "IdDoctor",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Medicament",
                keyColumn: "IdMedicament",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Patient",
                keyColumn: "IdPatient",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Prescription",
                keyColumn: "IdPrescription",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Doctor",
                keyColumn: "IdDoctor",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Patient",
                keyColumn: "IdPatient",
                keyValue: 1);
        }
    }
}
