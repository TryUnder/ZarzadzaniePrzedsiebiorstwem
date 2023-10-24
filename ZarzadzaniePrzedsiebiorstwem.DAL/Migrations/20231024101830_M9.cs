using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ZarzadzaniePrzedsiebiorstwem.DAL.Migrations
{
    public partial class M9 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Konto");

            migrationBuilder.RenameColumn(
                name: "KwotaKredyt",
                table: "Bilans",
                newName: "ZyskStrataZLatUbieglych");

            migrationBuilder.RenameColumn(
                name: "KwotaDebet",
                table: "Bilans",
                newName: "ZyskStrataNetto");

            migrationBuilder.AddColumn<decimal>(
                name: "AktywaObrotowe",
                table: "Bilans",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "AktywaTrwale",
                table: "Bilans",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "InneInwestycjeKrotkoterminowe",
                table: "Bilans",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "InwestycjeDlugoterminowe",
                table: "Bilans",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "InwestycjeKrotkoterminowe",
                table: "Bilans",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "KapitalFunduszWlasny",
                table: "Bilans",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "KapitalFunduzPodstawowy",
                table: "Bilans",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "KredytyIPozyczki",
                table: "Bilans",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "KredytyIPozyczkiKrotkoterminowe",
                table: "Bilans",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "KrotkoterminoweAktywaFinansowe",
                table: "Bilans",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "KrotkoterminoweRozliczeniaMiedzyokresowe",
                table: "Bilans",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "Materialy",
                table: "Bilans",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "NalezneWplatyNaKapitalPodstawowy",
                table: "Bilans",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "NaleznosciDlugoterminowe",
                table: "Bilans",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "NaleznosciDochodzoneNaDrodzeSadowej",
                table: "Bilans",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "NaleznosciKrotkoterminowe",
                table: "Bilans",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "NaleznosciZTytuluDostawIUslug",
                table: "Bilans",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "NaleznosciZTytuluPodatkow",
                table: "Bilans",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "OdpisyZZyskuNettoWCiaguRokuObrotowego",
                table: "Bilans",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<DateTime>(
                name: "OkresRozliczeniowy",
                table: "Bilans",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<decimal>(
                name: "PolproduktyIProduktyWToku",
                table: "Bilans",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "PozostaleKapitaly",
                table: "Bilans",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "PozostaleNalleznosci",
                table: "Bilans",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "PozostaleZobowiazania",
                table: "Bilans",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "ProduktyGotowe",
                table: "Bilans",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "RezerwyNaZobowiazania",
                table: "Bilans",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "RozliczeniaDlugoterminowe",
                table: "Bilans",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "RozliczeniaMiedzyokresowe",
                table: "Bilans",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "RzeczoweAktywaTrwale",
                table: "Bilans",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "SrodkiTrwale",
                table: "Bilans",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "SrodkiTrwaleWBudowie",
                table: "Bilans",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "SumaBilansowaAktywow",
                table: "Bilans",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "SumaBilansowaPasywow",
                table: "Bilans",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "Towary",
                table: "Bilans",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "UdzialyWlasne",
                table: "Bilans",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "WartosciNiematerialneIPrawne",
                table: "Bilans",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "ZaliczkaNaSrodkiTrwaleWBudowie",
                table: "Bilans",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "ZaliczkiNaDostawy",
                table: "Bilans",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "ZaliczkiOtrzymaneNaDostawy",
                table: "Bilans",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "Zapasy",
                table: "Bilans",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "ZobowiazaniaDlugoterminowe",
                table: "Bilans",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "ZobowiazaniaIRezerwyNaZobowiazania",
                table: "Bilans",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "ZobowiazaniaKrotkoterminowe",
                table: "Bilans",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "ZobowiazaniaWekslowe",
                table: "Bilans",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "ZobowiazaniaZTytuluWynagrodzen",
                table: "Bilans",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "ZobowiazaniaZTytyuluDostawIUslug",
                table: "Bilans",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "ZobowiazaniaZTytyuluPodatkow",
                table: "Bilans",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AktywaObrotowe",
                table: "Bilans");

            migrationBuilder.DropColumn(
                name: "AktywaTrwale",
                table: "Bilans");

            migrationBuilder.DropColumn(
                name: "InneInwestycjeKrotkoterminowe",
                table: "Bilans");

            migrationBuilder.DropColumn(
                name: "InwestycjeDlugoterminowe",
                table: "Bilans");

            migrationBuilder.DropColumn(
                name: "InwestycjeKrotkoterminowe",
                table: "Bilans");

            migrationBuilder.DropColumn(
                name: "KapitalFunduszWlasny",
                table: "Bilans");

            migrationBuilder.DropColumn(
                name: "KapitalFunduzPodstawowy",
                table: "Bilans");

            migrationBuilder.DropColumn(
                name: "KredytyIPozyczki",
                table: "Bilans");

            migrationBuilder.DropColumn(
                name: "KredytyIPozyczkiKrotkoterminowe",
                table: "Bilans");

            migrationBuilder.DropColumn(
                name: "KrotkoterminoweAktywaFinansowe",
                table: "Bilans");

            migrationBuilder.DropColumn(
                name: "KrotkoterminoweRozliczeniaMiedzyokresowe",
                table: "Bilans");

            migrationBuilder.DropColumn(
                name: "Materialy",
                table: "Bilans");

            migrationBuilder.DropColumn(
                name: "NalezneWplatyNaKapitalPodstawowy",
                table: "Bilans");

            migrationBuilder.DropColumn(
                name: "NaleznosciDlugoterminowe",
                table: "Bilans");

            migrationBuilder.DropColumn(
                name: "NaleznosciDochodzoneNaDrodzeSadowej",
                table: "Bilans");

            migrationBuilder.DropColumn(
                name: "NaleznosciKrotkoterminowe",
                table: "Bilans");

            migrationBuilder.DropColumn(
                name: "NaleznosciZTytuluDostawIUslug",
                table: "Bilans");

            migrationBuilder.DropColumn(
                name: "NaleznosciZTytuluPodatkow",
                table: "Bilans");

            migrationBuilder.DropColumn(
                name: "OdpisyZZyskuNettoWCiaguRokuObrotowego",
                table: "Bilans");

            migrationBuilder.DropColumn(
                name: "OkresRozliczeniowy",
                table: "Bilans");

            migrationBuilder.DropColumn(
                name: "PolproduktyIProduktyWToku",
                table: "Bilans");

            migrationBuilder.DropColumn(
                name: "PozostaleKapitaly",
                table: "Bilans");

            migrationBuilder.DropColumn(
                name: "PozostaleNalleznosci",
                table: "Bilans");

            migrationBuilder.DropColumn(
                name: "PozostaleZobowiazania",
                table: "Bilans");

            migrationBuilder.DropColumn(
                name: "ProduktyGotowe",
                table: "Bilans");

            migrationBuilder.DropColumn(
                name: "RezerwyNaZobowiazania",
                table: "Bilans");

            migrationBuilder.DropColumn(
                name: "RozliczeniaDlugoterminowe",
                table: "Bilans");

            migrationBuilder.DropColumn(
                name: "RozliczeniaMiedzyokresowe",
                table: "Bilans");

            migrationBuilder.DropColumn(
                name: "RzeczoweAktywaTrwale",
                table: "Bilans");

            migrationBuilder.DropColumn(
                name: "SrodkiTrwale",
                table: "Bilans");

            migrationBuilder.DropColumn(
                name: "SrodkiTrwaleWBudowie",
                table: "Bilans");

            migrationBuilder.DropColumn(
                name: "SumaBilansowaAktywow",
                table: "Bilans");

            migrationBuilder.DropColumn(
                name: "SumaBilansowaPasywow",
                table: "Bilans");

            migrationBuilder.DropColumn(
                name: "Towary",
                table: "Bilans");

            migrationBuilder.DropColumn(
                name: "UdzialyWlasne",
                table: "Bilans");

            migrationBuilder.DropColumn(
                name: "WartosciNiematerialneIPrawne",
                table: "Bilans");

            migrationBuilder.DropColumn(
                name: "ZaliczkaNaSrodkiTrwaleWBudowie",
                table: "Bilans");

            migrationBuilder.DropColumn(
                name: "ZaliczkiNaDostawy",
                table: "Bilans");

            migrationBuilder.DropColumn(
                name: "ZaliczkiOtrzymaneNaDostawy",
                table: "Bilans");

            migrationBuilder.DropColumn(
                name: "Zapasy",
                table: "Bilans");

            migrationBuilder.DropColumn(
                name: "ZobowiazaniaDlugoterminowe",
                table: "Bilans");

            migrationBuilder.DropColumn(
                name: "ZobowiazaniaIRezerwyNaZobowiazania",
                table: "Bilans");

            migrationBuilder.DropColumn(
                name: "ZobowiazaniaKrotkoterminowe",
                table: "Bilans");

            migrationBuilder.DropColumn(
                name: "ZobowiazaniaWekslowe",
                table: "Bilans");

            migrationBuilder.DropColumn(
                name: "ZobowiazaniaZTytuluWynagrodzen",
                table: "Bilans");

            migrationBuilder.DropColumn(
                name: "ZobowiazaniaZTytyuluDostawIUslug",
                table: "Bilans");

            migrationBuilder.DropColumn(
                name: "ZobowiazaniaZTytyuluPodatkow",
                table: "Bilans");

            migrationBuilder.RenameColumn(
                name: "ZyskStrataZLatUbieglych",
                table: "Bilans",
                newName: "KwotaKredyt");

            migrationBuilder.RenameColumn(
                name: "ZyskStrataNetto",
                table: "Bilans",
                newName: "KwotaDebet");

            migrationBuilder.CreateTable(
                name: "Konto",
                columns: table => new
                {
                    KontoId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BilansId = table.Column<int>(type: "int", nullable: false),
                    KwotaDebet = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    KwotaKredyt = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    NazwaKonta = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NumerKonta = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Konto", x => x.KontoId);
                    table.ForeignKey(
                        name: "FK_Konto_Bilans_BilansId",
                        column: x => x.BilansId,
                        principalTable: "Bilans",
                        principalColumn: "BilansId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Konto_BilansId",
                table: "Konto",
                column: "BilansId");
        }
    }
}
