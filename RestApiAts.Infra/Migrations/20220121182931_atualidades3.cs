using Microsoft.EntityFrameworkCore.Migrations;

namespace RestApiAts.Infra.Migrations
{
    public partial class atualidades3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IdCandidatura",
                table: "Vagas");

            migrationBuilder.DropColumn(
                name: "IdCandidatura",
                table: "Candidatos");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "IdCandidatura",
                table: "Vagas",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "IdCandidatura",
                table: "Candidatos",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
