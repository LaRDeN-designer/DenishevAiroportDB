using Microsoft.EntityFrameworkCore.Migrations;

namespace AirportDateBase.Migrations
{
    public partial class Mig5 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Crew_ID",
                table: "Plane",
                newName: "Employee_ID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Employee_ID",
                table: "Plane",
                newName: "Crew_ID");
        }
    }
}
