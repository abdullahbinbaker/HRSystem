using Microsoft.EntityFrameworkCore.Migrations;

namespace Infrastructure.Migrations
{
    public partial class CheckYearlyVacationDaysTaken : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            string procedure = @"Create PROCEDURE CheckYearlyVacationDaysTaken

            @EmployeeId int,
@Year int

AS
BEGIN


   select  sum(g.Days)days from (

Select Year  = Year(D)
      ,Month = Month(D)
      ,EmployeeId
      ,Days  = count(*)
 From  Holidays A
 Cross Apply (
                Select Top (DateDiff(DAY,[HolidayStartDate],[HolidayEndDate])+1) D=DateAdd(DAY,-1+Row_Number() Over (Order By (Select Null)),[HolidayStartDate]) 
                 From  master..spt_values 
             ) B
 -- YOUR OPTIONAL WHERE STATEMENT HERE --
 Group By EmployeeId,Year(D),Month(D)
 

 )g 
 
 where g.EmployeeId=@EmployeeId and g.Year=@Year
 group by g.EmployeeId,g.Year
 

END";
            migrationBuilder.Sql(procedure);
        }


        protected override void Down(MigrationBuilder migrationBuilder)
        {
            string procedure = @"DROP PROCEDURE CheckYearlyVacationDaysTaken";
            migrationBuilder.Sql(procedure);
        }
    }
}