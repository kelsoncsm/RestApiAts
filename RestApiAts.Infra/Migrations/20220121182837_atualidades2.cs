using Microsoft.EntityFrameworkCore.Migrations;

namespace RestApiAts.Infra.Migrations
{
    public partial class atualidades2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IdCandidato",
                table: "Candidaturas");

            migrationBuilder.DropColumn(
                name: "IdVaga",
                table: "Candidaturas");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "IdCandidato",
                table: "Candidaturas",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "IdVaga",
                table: "Candidaturas",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
