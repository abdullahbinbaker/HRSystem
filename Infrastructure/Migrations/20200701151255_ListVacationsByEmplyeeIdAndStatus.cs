using Microsoft.EntityFrameworkCore.Migrations;

namespace Infrastructure.Migrations
{
    public partial class ListVacationsByEmplyeeIdAndStatus : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            string procedure = @"CREATE PROCEDURE ListVacationsByEmployeeIdAndStatus

            @EmployeeId int ,
            @HolidayStatus nvarchar(MAX)
	
AS
BEGIN


    SELECT* from Holidays
  where EmployeeId = @EmployeeId and HolidayStatus=@HolidayStatus
	
END";
            migrationBuilder.Sql(procedure);
        }



        protected override void Down(MigrationBuilder migrationBuilder)
        {

            string procedure = @"DROP PROCEDURE ListVacationsByEmployeeIdAndStatus";
            migrationBuilder.Sql(procedure);
        }

    }

}