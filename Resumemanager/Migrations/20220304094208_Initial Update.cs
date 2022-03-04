using Microsoft.EntityFrameworkCore.Migrations;

namespace Resumemanager.Migrations
{
    public partial class InitialUpdate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "CompanyName",
                table: "Experiences",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Designation",
                table: "Experiences",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "YearsWorked",
                table: "Experiences",
                type: "int",
                maxLength: 10,
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "PhotoUrl",
                table: "Applications",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CompanyName",
                table: "Experiences");

            migrationBuilder.DropColumn(
                name: "Designation",
                table: "Experiences");

            migrationBuilder.DropColumn(
                name: "YearsWorked",
                table: "Experiences");

            migrationBuilder.DropColumn(
                name: "PhotoUrl",
                table: "Applications");
        }
    }
}
