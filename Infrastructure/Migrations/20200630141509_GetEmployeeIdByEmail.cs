using Microsoft.EntityFrameworkCore.Migrations;

namespace Infrastructure.Migrations
{
    public partial class GetEmployeeIdByEmail : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            string procedure = @"Create PROCEDURE RetrieveEmployeeIdByEmail

            @EmailAddress nvarchar(MAX)


AS
BEGIN


    SELECT Id from Employees
  where EmailAddress = @EmailAddress


END";
            migrationBuilder.Sql(procedure);
        }


        protected override void Down(MigrationBuilder migrationBuilder)
        {
            string procedure = @"DROP PROCEDURE  RetrieveEmployeeIdByEmail";
            migrationBuilder.Sql(procedure);
        }
    }
}