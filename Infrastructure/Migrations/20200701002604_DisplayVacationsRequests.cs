using Microsoft.EntityFrameworkCore.Migrations;

namespace Infrastructure.Migrations
{
    public partial class DisplayVacationsRequests : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            string procedure = @"Create PROCEDURE DisplayVacationsRequests

            @HolidayStatus nvarchar(MAX)


AS
BEGIN


    SELECT * from Holidays
  where HolidayStatus = @HolidayStatus


END";
            migrationBuilder.Sql(procedure);
        }


        protected override void Down(MigrationBuilder migrationBuilder)
        {
            string procedure = @"DROP PROCEDURE  DisplayVacationsRequests";
            migrationBuilder.Sql(procedure);
        }
    }
}
