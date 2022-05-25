using Microsoft.EntityFrameworkCore.Migrations;

namespace PrzelicznikMVVM.Bazadanych.Migrations
{
    public partial class PierwszaMigracja : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Rodzaje",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Nazwa = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Rodzaje", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Jednostki",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Nazwa = table.Column<string>(type: "TEXT", nullable: true),
                    Symbol = table.Column<string>(type: "TEXT", nullable: true),
                    RodzajId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Jednostki", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Jednostki_Rodzaje_RodzajId",
                        column: x => x.RodzajId,
                        principalTable: "Rodzaje",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PrzelicznikJednostek",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    ZrodloJednostkaID = table.Column<int>(type: "INTEGER", nullable: false),
                    ZrodloId = table.Column<int>(type: "INTEGER", nullable: true),
                    DocelowaJednostkaId = table.Column<int>(type: "INTEGER", nullable: false),
                    DocelowaId = table.Column<int>(type: "INTEGER", nullable: true),
                    WartoscPrzelicznika = table.Column<double>(type: "REAL", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PrzelicznikJednostek", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PrzelicznikJednostek_Jednostki_DocelowaId",
                        column: x => x.DocelowaId,
                        principalTable: "Jednostki",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PrzelicznikJednostek_Jednostki_ZrodloId",
                        column: x => x.ZrodloId,
                        principalTable: "Jednostki",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Jednostki_RodzajId",
                table: "Jednostki",
                column: "RodzajId");

            migrationBuilder.CreateIndex(
                name: "IX_PrzelicznikJednostek_DocelowaId",
                table: "PrzelicznikJednostek",
                column: "DocelowaId");

            migrationBuilder.CreateIndex(
                name: "IX_PrzelicznikJednostek_ZrodloId",
                table: "PrzelicznikJednostek",
                column: "ZrodloId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PrzelicznikJednostek");

            migrationBuilder.DropTable(
                name: "Jednostki");

            migrationBuilder.DropTable(
                name: "Rodzaje");
        }
    }
}
