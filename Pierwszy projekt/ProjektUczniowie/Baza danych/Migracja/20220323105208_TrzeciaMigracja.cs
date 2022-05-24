using Microsoft.EntityFrameworkCore.Migrations;

namespace ProjektUczniowie.Bazadanych.Migracja
{
    public partial class TrzeciaMigracja : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "RokUrodzenia",
                table: "Uczniowie",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "RokUrodzenia",
                table: "Uczniowie");
        }
    }
}
