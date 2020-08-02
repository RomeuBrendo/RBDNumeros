using Microsoft.EntityFrameworkCore.Migrations;

namespace RBDNumeros.Infra.Migrations
{
    public partial class InclusaoContabilizarNumeros : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "ContabilizarNumeros",
                table: "Categoria",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ContabilizarNumeros",
                table: "Categoria");
        }
    }
}
