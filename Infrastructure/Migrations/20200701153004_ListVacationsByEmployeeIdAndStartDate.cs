using Microsoft.EntityFrameworkCore.Migrations;

namespace Infrastructure.Migrations
{
    public partial class ListVacationsByEmployeeIdAndStartDate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            string procedure = @"CREATE PROCEDURE ListVacationsByEmployeeIdAndStartDate

            @EmployeeId int ,
            @HolidayStartDate date
	
AS
BEGIN


    SELECT* from Holidays
  where EmployeeId = @EmployeeId and HolidayStartDate=@HolidayStartDate
	
END";
            migrationBuilder.Sql(procedure);
        }



        protected override void Down(MigrationBuilder migrationBuilder)
        {

            string procedure = @"DROP PROCEDURE ListVacationsByEmployeeIdAndStartDate";
            migrationBuilder.Sql(procedure);
        }

    }

}