using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ZarzadzaniePrzedsiebiorstwem.DAL.Migrations
{
    public partial class M5 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ZuzycieMaterialowIProduktow",
                table: "RachunekZyskowIStrat",
                newName: "ZuzycieMaterialowIEnergii");

            migrationBuilder.RenameColumn(
                name: "StrataZTytuluRozchoduNiefinansowychAktywow",
                table: "RachunekZyskowIStrat",
                newName: "UbezpieczeniaSpoleczneIInneSwiadczenia");

            migrationBuilder.RenameColumn(
                name: "SkladkiNaZus",
                table: "RachunekZyskowIStrat",
                newName: "StrataZTytuluRozchoduNiefinansowychAktywowTrwalych");

            migrationBuilder.RenameColumn(
                name: "Inne",
                table: "RachunekZyskowIStrat",
                newName: "InnePrzychodyFinansowe");

            migrationBuilder.AlterColumn<decimal>(
                name: "PozostaleObowiazkoweZmniejszeniaZysku",
                table: "RachunekZyskowIStrat",
                type: "decimal(18,2)",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ZuzycieMaterialowIEnergii",
                table: "RachunekZyskowIStrat",
                newName: "ZuzycieMaterialowIProduktow");

            migrationBuilder.RenameColumn(
                name: "UbezpieczeniaSpoleczneIInneSwiadczenia",
                table: "RachunekZyskowIStrat",
                newName: "StrataZTytuluRozchoduNiefinansowychAktywow");

            migrationBuilder.RenameColumn(
                name: "StrataZTytuluRozchoduNiefinansowychAktywowTrwalych",
                table: "RachunekZyskowIStrat",
                newName: "SkladkiNaZus");

            migrationBuilder.RenameColumn(
                name: "InnePrzychodyFinansowe",
                table: "RachunekZyskowIStrat",
                newName: "Inne");

            migrationBuilder.AlterColumn<decimal>(
                name: "PozostaleObowiazkoweZmniejszeniaZysku",
                table: "RachunekZyskowIStrat",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)",
                oldNullable: true);
        }
    }
}
