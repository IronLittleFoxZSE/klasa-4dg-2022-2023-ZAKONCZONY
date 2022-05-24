using Microsoft.EntityFrameworkCore.Migrations;

namespace ProjektUczniowie.Bazadanych.Migracja
{
    public partial class DrugaMigracja : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Uczniowie",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Imie = table.Column<string>(type: "TEXT", nullable: true),
                    Nazwisko = table.Column<string>(type: "TEXT", nullable: true),
                    KlasaId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Uczniowie", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Uczniowie_Klasy_KlasaId",
                        column: x => x.KlasaId,
                        principalTable: "Klasy",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Uczniowie_KlasaId",
                table: "Uczniowie",
                column: "KlasaId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Uczniowie");
        }
    }
}
