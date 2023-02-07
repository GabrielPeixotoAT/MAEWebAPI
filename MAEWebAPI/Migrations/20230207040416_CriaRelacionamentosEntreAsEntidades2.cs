using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MAEWebAPI.Migrations
{
    public partial class CriaRelacionamentosEntreAsEntidades2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.CreateIndex(
                name: "IX_ClassSchedules_SchoolDayIDFK",
                table: "ClassSchedules",
                column: "SchoolDayIDFK");

            migrationBuilder.CreateIndex(
                name: "IX_ClassSchedules_SubjectIDFK",
                table: "ClassSchedules",
                column: "SubjectIDFK");

            migrationBuilder.AddForeignKey(
                name: "FK_ClassSchedules_SchoolDays_SchoolDayIDFK",
                table: "ClassSchedules",
                column: "SchoolDayIDFK",
                principalTable: "SchoolDays",
                principalColumn: "SchoolDayID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ClassSchedules_Subjects_SubjectIDFK",
                table: "ClassSchedules",
                column: "SubjectIDFK",
                principalTable: "Subjects",
                principalColumn: "SubjectID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ClassSchedules_SchoolDays_SchoolDayIDFK",
                table: "ClassSchedules");

            migrationBuilder.DropForeignKey(
                name: "FK_ClassSchedules_Subjects_SubjectIDFK",
                table: "ClassSchedules");

            migrationBuilder.DropIndex(
                name: "IX_ClassSchedules_SchoolDayIDFK",
                table: "ClassSchedules");

            migrationBuilder.DropIndex(
                name: "IX_ClassSchedules_SubjectIDFK",
                table: "ClassSchedules");

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
    }
}
