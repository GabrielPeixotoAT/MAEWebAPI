using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MAEWebAPI.Migrations
{
    public partial class CriaRelacionamentosEntreAsEntidades : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "Description",
                table: "SchoolDays",
                type: "datetime(6)",
                nullable: false,
                oldClrType: typeof(DateOnly),
                oldType: "date");

            migrationBuilder.AddColumn<int>(
                name: "SchoolDayID",
                table: "ClassSchedules",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "SubjectID",
                table: "ClassSchedules",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_ClassSchedules_SchoolDayID",
                table: "ClassSchedules",
                column: "SchoolDayID");

            migrationBuilder.CreateIndex(
                name: "IX_ClassSchedules_SubjectID",
                table: "ClassSchedules",
                column: "SubjectID");

            migrationBuilder.AddForeignKey(
                name: "FK_ClassSchedules_SchoolDays_SchoolDayID",
                table: "ClassSchedules",
                column: "SchoolDayID",
                principalTable: "SchoolDays",
                principalColumn: "SchoolDayID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ClassSchedules_Subjects_SubjectID",
                table: "ClassSchedules",
                column: "SubjectID",
                principalTable: "Subjects",
                principalColumn: "SubjectID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ClassSchedules_SchoolDays_SchoolDayID",
                table: "ClassSchedules");

            migrationBuilder.DropForeignKey(
                name: "FK_ClassSchedules_Subjects_SubjectID",
                table: "ClassSchedules");

            migrationBuilder.DropIndex(
                name: "IX_ClassSchedules_SchoolDayID",
                table: "ClassSchedules");

            migrationBuilder.DropIndex(
                name: "IX_ClassSchedules_SubjectID",
                table: "ClassSchedules");

            migrationBuilder.DropColumn(
                name: "SchoolDayID",
                table: "ClassSchedules");

            migrationBuilder.DropColumn(
                name: "SubjectID",
                table: "ClassSchedules");

            migrationBuilder.AlterColumn<DateOnly>(
                name: "Description",
                table: "SchoolDays",
                type: "date",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)");
        }
    }
}
