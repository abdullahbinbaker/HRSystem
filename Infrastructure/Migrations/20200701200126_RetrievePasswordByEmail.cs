using Microsoft.EntityFrameworkCore.Migrations;

namespace Infrastructure.Migrations
{
    public partial class RetrievePasswordByEmail : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {

            string procedure = @"Create PROCEDURE RetrievePasswordByEmail

            @EmailAddress nvarchar(MAX)


AS
BEGIN


    SELECT * from Logins
  where EmailAddress = @EmailAddress


END";
            migrationBuilder.Sql(procedure);
        }


        protected override void Down(MigrationBuilder migrationBuilder)
        {
            string procedure = @"DROP PROCEDURE  RetrievePasswordByEmail";
            migrationBuilder.Sql(procedure);
        }
    }
}