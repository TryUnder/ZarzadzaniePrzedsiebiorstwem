using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ZarzadzaniePrzedsiebiorstwem.DAL.Migrations
{
    public partial class M4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "RachunekZyskowIStrat",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DataPoczatkowa = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DataKoncowa = table.Column<DateTime>(type: "datetime2", nullable: false),
                    PrzychodyNettoZeSprzedazy = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    PrzychodyNettoZeSprzedazyProduktow = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    ZmianaStanuProduktow = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    KosztWytworzeniaProduktowNaWlasnePotrzebyJednostki = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    PrzychodyNettoZeSprzedazyTowarowIMaterialow = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    KosztyDzialalnosciOperacyjnej = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Amortyzacja = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    ZuzycieMaterialowIProduktow = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    UslugiObce = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    PodatkiIOplaty = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    Wynagrodzenia = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    SkladkiNaZus = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    PozostaleKosztyRodzajowe = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    WartoscSprzedanychTowarowIMaterialow = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    ZyskStrataZeSprzedazy = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    PozostalePrzychodyOperacyjne = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    ZyskZTytuluRozchoduNiefinansowychAktywowTrwalych = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    Inwestycje = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    ZwiekszenieWartosciAktywowNiefinansowych = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    InnePrzychodyOperacyjne = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    PozostaleKosztyOperacyjne = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    StrataZTytuluRozchoduNiefinansowychAktywow = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    ZmniejszenieWartosciAktywowNiefinansowych = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    InneKosztyOperacyjne = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    ZyskStrataZDzialalnosciOperacyjnej = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    PrzychodyFinansowe = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Dywidendy = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    OdsetkiDlaFirmy = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    ZyskZTytuluRozchoduAktywowFinansowych = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    AktualizacjaWartosciAktywowFinansowych = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    Inne = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    KosztyFinansowe = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    OdsetkiNaRzeczInnych = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    StrataZTytuluRozchoduAktywowFinansowych = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    AktualizacjaWartosciAktywowFinansowychStrata = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    InneKosztyFinansowe = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    ZyskStrataBrutto = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    PodatekDochodowy = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    PozostaleObowiazkoweZmniejszeniaZysku = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    ZyskStrataNetto = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RachunekZyskowIStrat", x => x.Id);
                    table.ForeignKey(
                        name: "FK_RachunekZyskowIStrat_User_UserId",
                        column: x => x.UserId,
                        principalTable: "User",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_RachunekZyskowIStrat_UserId",
                table: "RachunekZyskowIStrat",
                column: "UserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "RachunekZyskowIStrat");
        }
    }
}
