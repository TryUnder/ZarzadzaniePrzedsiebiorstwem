using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ZarzadzaniePrzedsiebiorstwem.DAL.Migrations
{
    public partial class M4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Pracownik_UrzadSkarbowy_UrzadSkarbowyId",
                table: "Pracownik");

            migrationBuilder.DropForeignKey(
                name: "FK_Przedsiebiorstwo_UrzadSkarbowy_UrzadSkarbowyId",
                table: "Przedsiebiorstwo");

            migrationBuilder.DropTable(
                name: "UrzadSkarbowy");

            migrationBuilder.DropIndex(
                name: "IX_Przedsiebiorstwo_UrzadSkarbowyId",
                table: "Przedsiebiorstwo");

            migrationBuilder.DropIndex(
                name: "IX_Pracownik_UrzadSkarbowyId",
                table: "Pracownik");

            migrationBuilder.DropColumn(
                name: "UrzadSkarbowyId",
                table: "Przedsiebiorstwo");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "UrzadSkarbowyId",
                table: "Przedsiebiorstwo",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "UrzadSkarbowy",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Adres = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    KodUs = table.Column<int>(type: "int", nullable: false),
                    Nazwa = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RachunekBankowy = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UrzadSkarbowy", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Przedsiebiorstwo_UrzadSkarbowyId",
                table: "Przedsiebiorstwo",
                column: "UrzadSkarbowyId");

            migrationBuilder.CreateIndex(
                name: "IX_Pracownik_UrzadSkarbowyId",
                table: "Pracownik",
                column: "UrzadSkarbowyId");

            migrationBuilder.AddForeignKey(
                name: "FK_Pracownik_UrzadSkarbowy_UrzadSkarbowyId",
                table: "Pracownik",
                column: "UrzadSkarbowyId",
                principalTable: "UrzadSkarbowy",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Przedsiebiorstwo_UrzadSkarbowy_UrzadSkarbowyId",
                table: "Przedsiebiorstwo",
                column: "UrzadSkarbowyId",
                principalTable: "UrzadSkarbowy",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
