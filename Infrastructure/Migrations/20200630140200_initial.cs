using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Infrastructure.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Employees",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true),
                    EmailAddress = table.Column<string>(nullable: true),
                    MobileNumber = table.Column<string>(nullable: true),
                    Gender = table.Column<string>(nullable: true),
                    Role = table.Column<string>(nullable: true),
                    BirthDate = table.Column<DateTime>(type: "date", nullable: false),
                    ManagerId = table.Column<int>(nullable: false),
                    VacationDaysAllowedYearly = table.Column<int>(nullable: true,defaultValue:30)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employees", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Holidays",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    EmployeeId = table.Column<int>(nullable: false),
                    HolidayStartDate = table.Column<DateTime>(type: "date", nullable: false),
                    HolidayEndDate = table.Column<DateTime>(type: "date", nullable: false),
                    HolidayStatus = table.Column<string>(nullable: true),
                    HolidayReason = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Holidays", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Logins",
                columns: table => new
                {
                    EmployeeId = table.Column<int>(nullable: false),
                    EmailAddress = table.Column<string>(nullable: false),
                    Password = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    
                    table.PrimaryKey("PK_Logins", x => x.EmployeeId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Employees");

            migrationBuilder.DropTable(
                name: "Holidays");

            migrationBuilder.DropTable(
                name: "Logins");
        }
    }
}
