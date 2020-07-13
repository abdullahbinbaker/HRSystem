using Microsoft.EntityFrameworkCore.Migrations;

namespace Infrastructure.Migrations
{
    public partial class RetrieveManagersEmployees : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            string procedure = @"Create PROCEDURE RetrieveManagersEmployees

            @ManagerId int


AS
BEGIN


    SELECT * from Employees
  where ManagerId = @ManagerId


END";
            migrationBuilder.Sql(procedure);
        }


        protected override void Down(MigrationBuilder migrationBuilder)
        {
            string procedure = @"DROP PROCEDURE  RetrieveManagersEmployees";
            migrationBuilder.Sql(procedure);
        }
    }
}