using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MAEWebAPI.Migrations
{
    public partial class ConlunaTotalClassesParaTabelaSubject : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "TotalClasses",
                table: "Subjects",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "SchoolDayIDFK",
                table: "ClassSchedules",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "TotalClasses",
                table: "Subjects");

            migrationBuilder.DropColumn(
                name: "SchoolDayIDFK",
                table: "ClassSchedules");
        }
    }
}
