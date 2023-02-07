using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MAEWebAPI.Migrations
{
    public partial class CriaRelacionamentosEntreAsEntidades3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_SubjectsAbstences_SubjectIDFK",
                table: "SubjectsAbstences",
                column: "SubjectIDFK");

            migrationBuilder.CreateIndex(
                name: "IX_Abstences_ClassSheduleIDFK",
                table: "Abstences",
                column: "ClassSheduleIDFK");

            migrationBuilder.CreateIndex(
                name: "IX_Abstences_SubjectIDFK",
                table: "Abstences",
                column: "SubjectIDFK");

            migrationBuilder.AddForeignKey(
                name: "FK_Abstences_ClassSchedules_ClassSheduleIDFK",
                table: "Abstences",
                column: "ClassSheduleIDFK",
                principalTable: "ClassSchedules",
                principalColumn: "ClassScheduleID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Abstences_Subjects_SubjectIDFK",
                table: "Abstences",
                column: "SubjectIDFK",
                principalTable: "Subjects",
                principalColumn: "SubjectID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_SubjectsAbstences_Subjects_SubjectIDFK",
                table: "SubjectsAbstences",
                column: "SubjectIDFK",
                principalTable: "Subjects",
                principalColumn: "SubjectID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Abstences_ClassSchedules_ClassSheduleIDFK",
                table: "Abstences");

            migrationBuilder.DropForeignKey(
                name: "FK_Abstences_Subjects_SubjectIDFK",
                table: "Abstences");

            migrationBuilder.DropForeignKey(
                name: "FK_SubjectsAbstences_Subjects_SubjectIDFK",
                table: "SubjectsAbstences");

            migrationBuilder.DropIndex(
                name: "IX_SubjectsAbstences_SubjectIDFK",
                table: "SubjectsAbstences");

            migrationBuilder.DropIndex(
                name: "IX_Abstences_ClassSheduleIDFK",
                table: "Abstences");

            migrationBuilder.DropIndex(
                name: "IX_Abstences_SubjectIDFK",
                table: "Abstences");
        }
    }
}
