using Microsoft.EntityFrameworkCore.Migrations;

namespace RBDNumeros.Infra.Migrations
{
    public partial class Inclusao_Categoria : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Carteira",
                table: "Tecnico",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Carteira",
                table: "Tecnico");
        }
    }
}
