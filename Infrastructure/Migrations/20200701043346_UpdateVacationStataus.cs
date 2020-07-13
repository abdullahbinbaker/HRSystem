using Microsoft.EntityFrameworkCore.Migrations;

namespace Infrastructure.Migrations
{
    public partial class UpdateVacationStataus : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            string procedure = @"create PROCEDURE UpdateVacationStatus

           
           
            @HolidayStatus nvarchar(MAX),
			@Id int
	
AS
BEGIN


             update Holidays set HolidayStatus=@HolidayStatus
             where Id=@Id
	
END";
            migrationBuilder.Sql(procedure);
        }


        protected override void Down(MigrationBuilder migrationBuilder)
        {
            string procedure = @"DROP PROCEDURE UpdateVacationStatus";
            migrationBuilder.Sql(procedure);
        }
    }
}


