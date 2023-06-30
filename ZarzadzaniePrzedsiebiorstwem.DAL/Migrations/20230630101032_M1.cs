using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ZarzadzaniePrzedsiebiorstwem.DAL.Migrations
{
    public partial class M1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "UrzadSkarbowy",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nazwa = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    KodUs = table.Column<int>(type: "int", nullable: false),
                    Adres = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RachunekBankowy = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UrzadSkarbowy", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "User",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Login = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Haslo = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Pracownik",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ImieNazwisko = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Pesel = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MiejsceUrodzenia = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DataUrodzenia = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UrzadSkarbowyId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pracownik", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Pracownik_UrzadSkarbowy_UrzadSkarbowyId",
                        column: x => x.UrzadSkarbowyId,
                        principalTable: "UrzadSkarbowy",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Przedsiebiorstwo",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NazwaSkrocona = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NazwaPelna = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NIP = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    REGON = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    daneAdresowe = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PowiatGmina = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Wojewodztwo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RachunekBankowy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FormaPrawna = table.Column<int>(type: "int", nullable: false),
                    UrzadSkarbowyId = table.Column<int>(type: "int", nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Przedsiebiorstwo", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Przedsiebiorstwo_UrzadSkarbowy_UrzadSkarbowyId",
                        column: x => x.UrzadSkarbowyId,
                        principalTable: "UrzadSkarbowy",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Przedsiebiorstwo_User_UserId",
                        column: x => x.UserId,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Pracownik_UrzadSkarbowyId",
                table: "Pracownik",
                column: "UrzadSkarbowyId");

            migrationBuilder.CreateIndex(
                name: "IX_Przedsiebiorstwo_UrzadSkarbowyId",
                table: "Przedsiebiorstwo",
                column: "UrzadSkarbowyId");

            migrationBuilder.CreateIndex(
                name: "IX_Przedsiebiorstwo_UserId",
                table: "Przedsiebiorstwo",
                column: "UserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Pracownik");

            migrationBuilder.DropTable(
                name: "Przedsiebiorstwo");

            migrationBuilder.DropTable(
                name: "UrzadSkarbowy");

            migrationBuilder.DropTable(
                name: "User");
        }
    }
}
