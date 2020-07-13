using Microsoft.EntityFrameworkCore.Migrations;

namespace Infrastructure.Migrations
{
    public partial class SearchForEmployeeByEmail : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            string procedure = @"Create PROCEDURE SearchForEmployeeByEmail

            @EmailAddress nvarchar(MAX)


AS
BEGIN


    SELECT * from Employees
  where EmailAddress = @EmailAddress


END";
            migrationBuilder.Sql(procedure);
        }


        protected override void Down(MigrationBuilder migrationBuilder)
        {
            string procedure = @"DROP PROCEDURE  SearchForEmployeeByEmail";
            migrationBuilder.Sql(procedure);
        }
    }
}