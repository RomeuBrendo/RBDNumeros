using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace RBDNumeros.Infra.Migrations
{
    public partial class Inicial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categoria",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Nome = table.Column<string>(maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categoria", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Rede",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Nome = table.Column<string>(maxLength: 1000, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Rede", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Tecnico",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Nome = table.Column<string>(nullable: true),
                    Carteira = table.Column<int>(nullable: false),
                    ContabilizarNumeros = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tecnico", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Cliente",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Nome = table.Column<string>(maxLength: 2000, nullable: false),
                    RedeId = table.Column<Guid>(nullable: true),
                    Carteira = table.Column<int>(maxLength: 1, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cliente", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Cliente_Rede_RedeId",
                        column: x => x.RedeId,
                        principalTable: "Rede",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Ticket",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    NumeroTicket = table.Column<long>(nullable: false),
                    ClienteId = table.Column<Guid>(nullable: true),
                    CategoriaId = table.Column<Guid>(nullable: true),
                    DataFinalizacao = table.Column<DateTime>(nullable: false),
                    DataResolvido = table.Column<DateTime>(nullable: false),
                    TecnicoId = table.Column<Guid>(nullable: true),
                    Carteira = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ticket", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Ticket_Categoria_CategoriaId",
                        column: x => x.CategoriaId,
                        principalTable: "Categoria",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Ticket_Cliente_ClienteId",
                        column: x => x.ClienteId,
                        principalTable: "Cliente",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Ticket_Tecnico_TecnicoId",
                        column: x => x.TecnicoId,
                        principalTable: "Tecnico",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Cliente_RedeId",
                table: "Cliente",
                column: "RedeId");

            migrationBuilder.CreateIndex(
                name: "IX_Ticket_CategoriaId",
                table: "Ticket",
                column: "CategoriaId");

            migrationBuilder.CreateIndex(
                name: "IX_Ticket_ClienteId",
                table: "Ticket",
                column: "ClienteId");

            migrationBuilder.CreateIndex(
                name: "IX_Ticket_TecnicoId",
                table: "Ticket",
                column: "TecnicoId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Ticket");

            migrationBuilder.DropTable(
                name: "Categoria");

            migrationBuilder.DropTable(
                name: "Cliente");

            migrationBuilder.DropTable(
                name: "Tecnico");

            migrationBuilder.DropTable(
                name: "Rede");
        }
    }
}
