using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Infrastructure.Migrations
{
    public partial class InitialTablesData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "Id", "BirthDate", "EmailAddress", "Gender", "ManagerId", "MobileNumber", "Name", "Role", "VacationDaysAllowedYearly" },
                values: new object[] { 1, new DateTime(1994, 9, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Admin@gmail.com", "Male", 1, "055555", "abdullah salem", "Admin", 30 });

            migrationBuilder.InsertData(
                table: "Logins",
                columns: new[] { "EmployeeId", "EmailAddress", "Password" },
                values: new object[] { 1, "Admin@gmail.com", "admin" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Logins",
                keyColumn: "EmployeeId",
                keyValue: 1);
        }
    }
}
