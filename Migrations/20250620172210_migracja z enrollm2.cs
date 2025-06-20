using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace APDB_Kolokwium_template.Migrations
{
    /// <inheritdoc />
    public partial class migracjazenrollm2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Enrollment",
                columns: new[] { "Course_ID", "Student_ID", "EnrollmentDate" },
                values: new object[,]
                {
                    { 101, 1, new DateTime(2024, 10, 1, 10, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 102, 2, new DateTime(2024, 10, 2, 9, 30, 0, 0, DateTimeKind.Unspecified) }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Enrollment",
                keyColumns: new[] { "Course_ID", "Student_ID" },
                keyValues: new object[] { 101, 1 });

            migrationBuilder.DeleteData(
                table: "Enrollment",
                keyColumns: new[] { "Course_ID", "Student_ID" },
                keyValues: new object[] { 102, 2 });
        }
    }
}
