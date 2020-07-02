using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace RBDNumeros.Infra.Migrations
{
    public partial class Mudancas_estruturas : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Cliente_Rede_RedeId",
                table: "Cliente");

            migrationBuilder.DropTable(
                name: "Rede");

            migrationBuilder.DropIndex(
                name: "IX_Cliente_RedeId",
                table: "Cliente");

            migrationBuilder.DropColumn(
                name: "RedeId",
                table: "Cliente");

            migrationBuilder.CreateTable(
                name: "ConfiguracaoPlanilha",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    NumeroTicket = table.Column<string>(nullable: false),
                    ClienteNome = table.Column<string>(nullable: false),
                    Categoria = table.Column<string>(nullable: false),
                    DataAberturaTicket = table.Column<string>(nullable: false),
                    DataResolvido = table.Column<string>(nullable: false),
                    Tecnico = table.Column<string>(nullable: false),
                    Carteira = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ConfiguracaoPlanilha", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ConfiguracaoPlanilha");

            migrationBuilder.AddColumn<Guid>(
                name: "RedeId",
                table: "Cliente",
                type: "char(36)",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Rede",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "char(36)", nullable: false),
                    Nome = table.Column<string>(type: "varchar(1000) CHARACTER SET utf8mb4", maxLength: 1000, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Rede", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Cliente_RedeId",
                table: "Cliente",
                column: "RedeId");

            migrationBuilder.AddForeignKey(
                name: "FK_Cliente_Rede_RedeId",
                table: "Cliente",
                column: "RedeId",
                principalTable: "Rede",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
