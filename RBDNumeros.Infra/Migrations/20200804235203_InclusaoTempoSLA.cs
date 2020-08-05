using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace RBDNumeros.Infra.Migrations
{
    public partial class InclusaoTempoSLA : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<TimeSpan>(
                name: "TempoVida",
                table: "Ticket",
                nullable: false,
                defaultValue: new TimeSpan(0, 0, 0, 0, 0));

            migrationBuilder.AddColumn<string>(
                name: "TempoVida",
                table: "ConfiguracaoPlanilha",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "TempoVida",
                table: "Ticket");

            migrationBuilder.DropColumn(
                name: "TempoVida",
                table: "ConfiguracaoPlanilha");
        }
    }
}
