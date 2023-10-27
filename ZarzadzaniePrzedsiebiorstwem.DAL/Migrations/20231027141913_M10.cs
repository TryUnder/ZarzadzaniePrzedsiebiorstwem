using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ZarzadzaniePrzedsiebiorstwem.DAL.Migrations
{
    public partial class M10 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "PozostaleNalleznosci",
                table: "Bilans",
                newName: "PozostaleNaleznosci");

            migrationBuilder.RenameColumn(
                name: "KapitalFunduzPodstawowy",
                table: "Bilans",
                newName: "KapitalFunduszPodstawowy");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "PozostaleNaleznosci",
                table: "Bilans",
                newName: "PozostaleNalleznosci");

            migrationBuilder.RenameColumn(
                name: "KapitalFunduszPodstawowy",
                table: "Bilans",
                newName: "KapitalFunduzPodstawowy");
        }
    }
}
