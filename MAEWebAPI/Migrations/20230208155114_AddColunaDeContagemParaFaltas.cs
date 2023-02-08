using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MAEWebAPI.Migrations
{
    public partial class AddColunaDeContagemParaFaltas : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ClassCount",
                table: "Abstences",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ClassCount",
                table: "Abstences");
        }
    }
}
