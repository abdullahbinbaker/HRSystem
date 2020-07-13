using Microsoft.EntityFrameworkCore.Migrations;

namespace Infrastructure.Migrations
{
    public partial class CheckLoginSP : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
			string procedure = @"CREATE PROCEDURE CheckLogin
	
	@EmailAddress nvarchar(max),
	@Password nvarchar(max)
AS
BEGIN
	
	SELECT *  from Employees
	where Id= (select EmployeeId from Logins
	where EmailAddress=@EmailAddress and Password=@Password
	)
END";
			migrationBuilder.Sql(procedure);
		}

		protected override void Down(MigrationBuilder migrationBuilder)
		{
			string procedure = @"DROP PROCEDURE CheckLogin";
			migrationBuilder.Sql(procedure);
		}

	}
}
