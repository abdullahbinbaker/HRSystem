using Microsoft.EntityFrameworkCore.Migrations;

namespace Infrastructure.Migrations
{
    public partial class ListVacationsByEmployeeId : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            string procedure = @"CREATE PROCEDURE ListVacationsByEmployeeId

            @EmployeeId nvarchar(450)
	
AS
BEGIN


    SELECT* from Holidays
  where EmployeeId = @EmployeeId
	
END";
            migrationBuilder.Sql(procedure);
        }



        protected override void Down(MigrationBuilder migrationBuilder)
        {

            string procedure = @"DROP PROCEDURE ListVacationsByEmployeeId";
            migrationBuilder.Sql(procedure);
        }

    }

}